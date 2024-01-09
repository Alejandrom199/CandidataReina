using CapaVisual;
using CapaVisual.ModuloDocente;

namespace CandidataReina
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            frmLogin pantallaLogin = new frmLogin();
            Application.Run(new frmGaleriaFotos());
        }

    }
}