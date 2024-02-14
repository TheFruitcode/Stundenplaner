using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stundenplanner
{
    internal class ModelXML : IModel
    {
        private static XDocument doc;

        //IView IModel.View { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //IController IModel.Controller { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IView IModel.View { get; set; }
        IController IModel.Controller { get; set; }

        void IModel.Speichern(string calender, string terminbeschreibung) { throw new NotImplementedException(); }
        void IModel.Terminauswahl_open() { throw new NotImplementedException(); }
        void IModel.Delete_Termin(int ID) { throw new NotImplementedException(); }
        void IModel.update_Termine() { throw new NotImplementedException(); }
        void IModel.laufend() { throw new NotImplementedException(); }
        string IModel.Loeschen() { throw new NotImplementedException(); }
        void IModel.Termin() {
            try
            {
                doc = XDocument.Load("Termindaten.xml");

                IEnumerable<XElement> elements = doc.Elements("Stundenplaner").Elements("Termine");
                foreach (XElement e in elements)
                {
                    //Console.WriteLine("Elemente: " + e.Value);
                }
            } 
            catch
            {
                XDocument doc = new XDocument(
                    new XElement("Stundenplaner",
                        new XElement("Termine",
                            new XElement("TerminID", "1"),
                            new XElement("Terminbeschreibung", "Für Klausur lernen"),
                            new XElement("Datum", "01.02.2024")
                            )
                    )
                            );
                doc.Save("Termindaten.xml");
            }
        }
    }
}
