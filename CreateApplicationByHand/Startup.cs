using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CreateApplicationByHand
{
    public class Startup
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            Window win = new Window();

            win.Title = "这是应用程序的主窗口";
            win.Show();
            app.Run();
        }
    }
}
