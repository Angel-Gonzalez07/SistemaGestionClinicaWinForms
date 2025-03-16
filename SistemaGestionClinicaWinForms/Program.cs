using System;
using System.Windows.Forms;
using SistemaGestionClinicaWinForms;

namespace SistemaGestionClinica
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Inicia la app con Form1
        }
    }
}

