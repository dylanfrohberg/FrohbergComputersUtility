using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrohbergComputers
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create the splash screen form
            using (SplashScreenForm splashScreen = new SplashScreenForm())
            {
                // Create the main form
                frohbergcomputersForm mainForm = new frohbergcomputersForm();

                // Start background work to load the main form
                Task.Run(async () =>
                {
                    // Simulate some loading work
                    await Task.Delay(5000); // Replace with actual initialization code

                    // Close the splash screen and show the main form
                    splashScreen.Invoke((Action)(() =>
                    {
                        splashScreen.Close();
                        mainForm.Show();
                    }));
                });

                // Show the splash screen modally
                splashScreen.ShowDialog();

                // Start the application with the main form
                Application.Run(mainForm);
            }
        }
    }
}
