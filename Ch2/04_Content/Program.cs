using System;
using System.Security.Principal;
using System.Windows;
using System.Windows.Controls;

namespace IllustratedWPF.Content
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Window window = new Window();
            window.Title = "My Program Window";
            window.Width = 300;
            window.Height = 200;

            Button button = new Button();

            // Uncomment these two statement, the effect will be very different.
            //button.HorizontalAlignment = HorizontalAlignment.Center;
            //button.VerticalAlignment = VerticalAlignment.Center;

            button.Content = "Click Me";
            window.Content = button;

            Application application = new Application();
            application.Run(window);
        }
    }
}
