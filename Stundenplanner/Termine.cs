using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stundenplanner
{
    public partial class Termine : Form
    {
        //Controller controller;

        private IController controller;

        public Termine(Controller c)
        {
            InitializeComponent();
            controller = c;
        }

        public void addTermin(string ID, string Datum, string Info)
        {
            string Terminladen = Terminliste.Text;

            Terminladen = Terminladen + "(" + ID + ") " + Datum + " " + Info + "\n";
            Terminliste.Text = Terminladen;
        }

        private void TerminLoeschen_Click(object sender, EventArgs e)
        {
            controller.Terminauswahl_open();
        }

        public void clear_Termine()
        {
            Terminliste.Clear();
        }
    }
}
