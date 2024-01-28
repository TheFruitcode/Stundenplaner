using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stundenplanner
{
    internal interface IController
    {
        IModel Model { get; set; }
        IView View { get; set; }

        void Speichern(string calender, string terminbeschreibung);
        string Loeschen();
        void Termin();
        void laufend();
        void Delete_Termin(int ID);
        void Terminauswahl_open();
    }
}
