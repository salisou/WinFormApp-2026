using OfficeOpenXml;

namespace Demo1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Imposta la licenza per EPPlus (va fatto una sola volta all'avvio)
            ExcelPackage.License.SetNonCommercialPersonal("Moussa");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frnHome());
        }
    }
}