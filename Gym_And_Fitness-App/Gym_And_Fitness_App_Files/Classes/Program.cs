using GymAndFitness.Forms;
using System;
using System.Windows.Forms;


namespace GymAndFitness
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var loadingForm = new LoadingForm())
            {
                loadingForm.ShowDialog(); // Modal loading form
            }
            Application.Run(new LoginForm()); // Main form is now LoginForm

        }
    }
}
