using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stundenplanner
{
    internal class ModelXML : IModel
    {
        IView IModel.View { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IController IModel.Controller { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IModel.Speichern(string calender, string terminbeschreibung) { throw new NotImplementedException(); }
        void IModel.Terminauswahl_open() { throw new NotImplementedException(); }
        void IModel.Delete_Termin(int ID) { throw new NotImplementedException(); }
        void IModel.update_Termine() { throw new NotImplementedException(); }
        void IModel.laufend() { throw new NotImplementedException(); }
        string IModel.Loeschen() { throw new NotImplementedException(); }
        void IModel.Termin() { throw new NotImplementedException(); }


        public ModelXML() 
        {
            XDocument doc = new XDocument(
                new XElement("Stundenplaner",
                    new XElement("Termine",
                        new XElement("TerminID", ""),
                        new XElement("Terminbeschreibung", ""),
                        new XElement("Datum", "")
                            )
                     )
                             );
            doc.Save("Termindaten.xml");
        }
    }
}
