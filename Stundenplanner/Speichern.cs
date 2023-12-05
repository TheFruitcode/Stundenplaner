using View.cs;
using System;
using System.Windows.Forms;
using System.Text;
using System.ComponentModel;
using System.Data;

public class Speichern
{
    calender = monthCalendar1_DateChanged;
    beschreibung = richTextBox1_TextChanged;

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