using TVCheck.WinApp.Shows;
using TVCheck.WinApp.Users;

namespace TvCheck.WinApp
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
            var start = new frmShows();
            Application.Run(start);
        }
    }
}