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
        public Termine()
        {
            InitializeComponent();
        }

        public void addTermin(string Datum, string Info)
        {
            string Terminladen = Terminliste.Text;

            Terminladen = Terminladen + Datum + ":\n" + Info + "\n";
            Terminliste.Text = Terminladen;
        }
    }
}
