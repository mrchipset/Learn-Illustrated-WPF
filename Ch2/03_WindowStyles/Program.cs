using System;
using System.Windows;

namespace _03_WindowStyles
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Window window = new Window();
            window.Height = 75;
            window.Width = 300;
            window.Title = "WindowStyles";

            window.WindowStyle = WindowStyle.SingleBorderWindow;
            window.Content = window.WindowStyle.ToString();

            Application app = new Application();
            app.Run(window);
        }
    }
}
