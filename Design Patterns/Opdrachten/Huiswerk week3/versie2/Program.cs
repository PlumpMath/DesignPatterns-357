using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using versie2.Models;
using versie2.Controllers;


namespace versie2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TreinReis treinreis = new TreinReis();
            TreinController controller = new TreinController(treinreis);

            Application.Run(new Form1(controller, treinreis));
            

        }
    }
}
