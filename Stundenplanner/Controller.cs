using Google.Protobuf.WellKnownTypes;
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
    public class Controller
    {
        Termine termine;
        public Controller()
        {
            conn = new MySqlConnection(myConnectionString);
        }

        private string myConnectionString = "server=localhost; uid=root; pwd=; database=stundenplaner; Convert Zero Datetime=True;";

        MySqlConnection conn;

        public void Speichern(string calender, string terminbeschreibung)
        {
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
            termine = new Termine(this);
            termine.Show();

            try
            {
                conn.Open();
                MySqlCommand mycommand = conn.CreateCommand();
                mycommand.CommandText = "Select ID_Termine, Datum, Beschreibung from TerminSpeichern order by Datum;";
                MySqlDataReader reader = mycommand.ExecuteReader();
                while (reader.Read())
                {
                    termine.addTermin(reader.GetInt64(0).ToString(), reader.GetDateTime(1).ToShortDateString(), reader.GetString(2));
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string Loeschen()
        {
            return "";
        }

        public void Terminauswahl_open()
        {
            Terminauswahl terminauswahl = new Terminauswahl(this);
            terminauswahl.Show();
        }

        public void Delete_Termin(int ID)
        {
            try
            {
                conn.Open();
                MySqlCommand mycommand = conn.CreateCommand();
                mycommand.CommandText = "Delete from TerminSpeichern where ID_Termine = "+ ID.ToString() +";";
                mycommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            update_Termine();
        }

        public void update_Termine()
        {
            termine.clear_Termine();
            try
            {
                conn.Open();
                MySqlCommand mycommand = conn.CreateCommand();
                mycommand.CommandText = "Select ID_Termine, Datum, Beschreibung from TerminSpeichern order by Datum;";
                MySqlDataReader reader = mycommand.ExecuteReader();
                while (reader.Read())
                {
                    termine.addTermin(reader.GetInt64(0).ToString(), reader.GetDateTime(1).ToShortDateString(), reader.GetString(2));
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void laufend()
        {
            LaufendeAufgaben laufendeAufgaben = new LaufendeAufgaben();
            laufendeAufgaben.Show();

            try
            {
                if (DateTime.Now.Date <= ) {
                    conn.Open();
                    MySqlCommand mycommand = conn.CreateCommand();
                    mycommand.CommandText = "Select ID_Termine, Datum, Beschreibung from TerminSpeichern order by Datum;";
                    MySqlDataReader reader = mycommand.ExecuteReader();
                    while (reader.Read())
                    {
                        termine.addTermin(reader.GetInt64(0).ToString(), reader.GetDateTime(1).ToShortDateString(), reader.GetString(2));
                    }
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}




//Credits: SEBASTIAN STEFEN Peer Review und eine MEGA HILFE!!!!