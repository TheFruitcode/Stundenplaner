using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stundenplanner
{
    internal static class Program
    {
        private static IModel model;
        private static IView view;
        private static IController controller;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            model = new ModelXML();
            view = new View();
            controller = new Controller();

            view.Controller = controller;
            view.Model = model;

            controller.Model = model;
            controller.View = view;

            model.Controller = controller;
            model.View = view;

            Application.Run((View)view);
        }
    }
}
