using View.cs;
using System;

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