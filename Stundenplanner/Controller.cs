using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stundenplanner
{
    public class Controller : IController
    {
        private IModel model;
        private IView view;

        public Controller()
        {

        }

        IModel IController.Model { get => model; set => model = value; }
        IView IController.View { get => view; set => view = value; }

        public void Delete_Termin(int ID)
        {
            throw new NotImplementedException();
        }

        public void laufend()
        {
            throw new NotImplementedException();
        }

        public string Loeschen()
        {
            throw new NotImplementedException();
        }

        public void Terminauswahl_open()
        {
            Terminauswahl terminauswahl = new Terminauswahl(this);
            terminauswahl.Show();
        }

        void IController.Speichern(string calender, string terminbeschreibung)
        {
            model.Speichern(calender, terminbeschreibung);
        }
        void IController.Termin()
        {
            model.Termin();
        }

    }
}




//Credits: SEBASTIAN STEFEN Peer Review und eine MEGA HILFE!!!!