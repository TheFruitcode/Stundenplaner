using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Stundenplanner
{
    internal interface IModel
    {
        IView View { get; set; }
        IController Controller { get; set; }

        void Speichern(string calender, string terminbeschreibung);
        void update_Termine();
        void laufend();
        string Loeschen();
        void Termin();
        void Delete_Termin(int ID);
        void Terminauswahl_open();
    }
}
