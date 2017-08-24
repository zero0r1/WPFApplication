using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HandleCommandLineDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// 通过类属性=>调试=>命令行参数执行相应的动作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            bool startMinmized = false;

            for (int i = 0; i < e.Args.Length; i++)
            {
                if (e.Args[i] == "/StartMinmized")
                    startMinmized = true;
            }

            MainWindow win = new MainWindow();

            if (startMinmized)
            {
                win.WindowState = WindowState.Minimized;
                win.Content = "当前命令参数为:" + e.Args[0];
            }
            win.Show();
        }
    }
}
