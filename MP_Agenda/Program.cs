using MP_Agenda.Operacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_Agenda
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
            //Application.Run(new MP_Agenda.frmLogin());
            Application.Run(new MP_Agenda.frmPrincipal());
            //Application.Run(new frmDashboard());

        }
    }
}
