using AgendaClinica.Formularios;
using System;
using System.Windows.Forms;

namespace AgendaClinica
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPaciente());
        }
    }
}
