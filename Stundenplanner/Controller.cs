using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stundenplanner
{
    internal class Controller
    {
        public Controller()
        {
            conn = new MySqlConnection(myConnectionString);
        }

        private string myConnectionString = "server=localhost; uid=root; pwd=; database=stundenplaner; Convert Zero Datetime=True;";

        MySqlConnection conn;

        public void Speichern(string calender, string terminbeschreibung)
        {
            MessageBox.Show(calender + terminbeschreibung);
            try
            {
                conn.Open();

                MySqlCommand mycommand = conn.CreateCommand();

                mycommand.CommandText = "Insert into TerminSpeichern (Datum, Beschreibung) values('" + calender + "',' " + terminbeschreibung + "');";

                mycommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Termin()
        {
            Termine termine = new Termine();
            termine.Show();

            try
            {
                conn.Open();
                MySqlCommand mycommand = conn.CreateCommand();
                mycommand.CommandText = "Select Datum, Beschreibung from TerminSpeichern;";
                MySqlDataReader reader = mycommand.ExecuteReader();
                while (reader.Read())
                {
                    termine.addTermin(reader.GetDateTime(0).ToShortDateString(), reader.GetString(1));
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Loeschen()
        {

        }
    }
}

//Credits: SEBASTIAN STEFEN Peer Review
