using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SingleInstanceWithCommunication
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow win = new SingleInstanceWithCommunication.MainWindow();
            this.MainWindow = win;
            win.Show();
            if (e.Args.Length > 0)
                ShowWindowText(e.Args[0]);
        }

        public void ShowWindowText(string fileName)
        {
            Window1 win = new Window1();
            win.Title = fileName;
            ((MainWindow)this.MainWindow).lstBox.Items.Add(fileName);
            win.Owner = this.MainWindow;
            win.LoadFile(fileName);
            win.Show();
        }
    }
}
