using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace SingleInstanceApplication
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Mutex 在System.Threading命名空间中,成为同步基元,或者成为互斥元.
        /// 当创建一个引用程序类时,将同时创建一个系统范围内的命名的Mutex对象.
        /// 这个互斥单元在整个操作系统中都是可见的.
        /// </summary>
        Mutex mutex;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            string mutexName = "SingleInstanceApplication";

            bool CreatedNew;

            //判断是否已经创建相同实例名称的应用程序
            mutex = new Mutex(true, mutexName, out CreatedNew);
            if (!CreatedNew)
            {
                MessageBox.Show("已经存在一个引用程序势力");
                Shutdown();
            }
        }
    }
}
