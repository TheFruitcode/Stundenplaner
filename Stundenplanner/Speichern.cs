using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public class Speichern
    {
        Console.WriteLine("Hello World");

        string calender = monthCalendar1;
        string Terminbeschreibung = richTextBox1;
        public Speichern()
        {
            string myConnectionString = "server=127.0.0.1; uid=root; pwd=''; database:stundenplaner;";

            MySqlConnection conn = new MySqlConnection(myConnectionString);
            conn.Open();

            MySqlCommand mycommand = conn.CreateCommand();

            mycommand.CommandText = "Insert into TerminSpeichern (ID_Termine, Datum, Beschreibung) values();";
            conn.Close();
        }
    }
}