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
        }

        public void Speichern(string calender, string terminbeschreibung)
        {
            MessageBox.Show(calender + terminbeschreibung);
            try
            {
                string myConnectionString = "server=localhost; uid=root; pwd=; database=stundenplaner;";

                MySqlConnection conn = new MySqlConnection(myConnectionString);
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

        }
    }
}
