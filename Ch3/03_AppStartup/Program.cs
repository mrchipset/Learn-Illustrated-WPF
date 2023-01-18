using System;
using System.Windows;

namespace IllustratedWPF.AppStartup
{
    class MyWindow : Window
    {
        public MyWindow()
        {
            Width = 300;
            Height = 200;
            Title = "My Program Window";
            Content = "This application handles the Startup event.";
        }
    }
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            MyWindow window = new MyWindow();
            Application application = new Application();
            application.Startup += Application_Startup;
            application.Run(window);
        }

        private static void Application_Startup(object sender, StartupEventArgs e)
        {
            MessageBox.Show("The application is starting.", "Starting Message");
        }
    }
}
