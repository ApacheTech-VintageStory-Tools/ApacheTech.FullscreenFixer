using ApacheTech.FullscreenFixer.Extensions;
using System;
using System.Windows.Forms;

namespace ApacheTech.FullscreenFixer
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (!UserEx.IsAdministrator())
            {
                MessageBox.Show(@"Please run application as Administrator.", @"Fullscreenificator");
                Application.Exit();
                return;
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrontEnd());
        }
    }
}