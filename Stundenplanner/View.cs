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
    public partial class View : Form, IView
    {

        private IModel model;
        private IController controller;

        //Controller controller = new Controller();
        public View()
        {
            InitializeComponent();
        }

        IModel IView.Model { get => model; set => model = value; }
        IController IView.Controller { get => controller; set => controller = value; }

        private void speichern_btn_Click(object sender, EventArgs e)
        {
            string calender = Calender.SelectionRange.Start.Year.ToString() + "-" + Calender.SelectionRange.Start.Month.ToString() + "-" + Calender.SelectionRange.Start.Day.ToString();
            string terminbeschreibung = Terminbeschreibung.Text;

            controller.Speichern(calender, terminbeschreibung);
        }

        private void loeschen_btn_Click(object sender, EventArgs e)
        {
            Terminbeschreibung.Text = controller.Loeschen();
        }

        private void termine_btn_Click(object sender, EventArgs e)
        {
            controller.Termin();
        }

        private void laufende_Click(object sender, EventArgs e)
        {
            controller.laufend();
        }

        private void abgelaufende_Click(object sender, EventArgs e)
        {

        }
    }
}

