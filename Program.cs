using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //minimiza la ventana que dispara un evento en el cual oculta la ventana
            FormManager.GetInstance().WindowState = FormWindowState.Minimized;
            Application.Run(FormManager.GetInstance());
        }
    }
}
