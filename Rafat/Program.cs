using Rafat.Gui.PropertysGui;
using Rafat.Gui.ReportGui;
using Rafat.Gui.SettingsGui;
using Rafat.Gui.ToastGui;
using Rafat.Gui.UsersGui;

namespace Rafat
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
            Application.Run(new StartForm());
        }
    }
}