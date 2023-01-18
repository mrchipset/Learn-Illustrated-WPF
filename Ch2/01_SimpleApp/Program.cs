using System;
using System.Windows;

namespace IllustratedWPF.HiThere
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Create the windwo object
            Window myWindow = new Window();
            myWindow.Title = "My Simple Window";
            myWindow.Content = "Hi there!";

            // Create Application
            Application myApp = new Application();
            myApp.Run(myWindow);
        }
    }
}
