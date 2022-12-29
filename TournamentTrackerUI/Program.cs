using System.ComponentModel.DataAnnotations;
using TrackerLibrary;

namespace TournamentTrackerUI
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Initialize the database connection
            TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.TextFile); 
            Application.Run(new CreatePrizeForm());
            //Application.Run(new TournamentDashbordForm());
        }
    }
}