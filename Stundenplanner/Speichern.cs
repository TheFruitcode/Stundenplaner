using System;

public class Speichern
{
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