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
    public partial class Terminauswahl : Form
    {
        Controller controller;
        public Terminauswahl(Controller c)
        {
            InitializeComponent();
            controller = c;
        }

        private void senden_Click(object sender, EventArgs e)
        {
            controller.Delete_Termin(Convert.ToInt32(ID_box.Value));
        }
    }
}
