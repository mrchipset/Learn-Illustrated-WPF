using System;
using System.Windows;

namespace CreateSimpleWindowCode
{
    class MyWindow : Window
    {
        public MyWindow()
        {
            Width = 300;
            Height = 200;
            Title = "My Simple Window";
            Content = "Hi There";
        }
    }
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            MyWindow window = new MyWindow();
            window.Show();

            Application application = new Application();
            application.Run();
        }
    }
}
