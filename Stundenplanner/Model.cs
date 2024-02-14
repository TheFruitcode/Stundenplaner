using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Stundenplanner
{
    internal class Model : IModel
    {
        Termine termine;

        private IView view;
        private IController controller;

        private string connectionString = "server=localhost; uid=root; pwd=; database=stundenplaner; Convert Zero Datetime=True;";

        MySqlConnection conn;

        IView IModel.View { get => view; set => view = value; }
        IController IModel.Controller { get => controller; set => controller = value; }

        public Model()
        {
            conn = new MySqlConnection(connectionString);
        }

        void IModel.Speichern(string calender, string terminbeschreibung)
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

        void IModel.Termin()
        {
            ////termine = new Termine(this);
            //termine.Show();

            //try
            //{
            //    conn.Open();
            //    MySqlCommand mycommand = conn.CreateCommand();
            //    mycommand.CommandText = "Select ID_Termine, Datum, Beschreibung from TerminSpeichern order by Datum;";
            //    MySqlDataReader reader = mycommand.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        termine.addTermin(reader.GetInt64(0).ToString(), reader.GetDateTime(1).ToShortDateString(), reader.GetString(2));
            //    }
            //    conn.Close();
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}


        }

        string IModel.Loeschen()
        {
            return "";
        }

        void IModel.Terminauswahl_open()
        {
            //Terminauswahl terminauswahl = new Terminauswahl();
            //terminauswahl.Show();
        }

        void IModel.Delete_Termin(int ID)
        {
            try
            {
                conn.Open();
                MySqlCommand mycommand = conn.CreateCommand();
                mycommand.CommandText = "Delete from TerminSpeichern where ID_Termine = " + ID.ToString() + ";";
                mycommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //update_Termine();
        }

        void IModel.update_Termine()
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

        void IModel.laufend()
        {
            LaufendeAufgaben laufendeAufgaben = new LaufendeAufgaben();
            laufendeAufgaben.Show();

            try
            {
                conn.Open();
                MySqlCommand mycommand = conn.CreateCommand();
                mycommand.CommandText = "Select ID_Termine, Datum, Beschreibung from TerminSpeichern where Datum > '" + DateTime.Now.Date.ToString() + "';";
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

    }
}
