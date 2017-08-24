using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ApplicationEventDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public enum ApplicationExitCode
        {
            Success = 0,
            Failure = 1,
            CantWriteToApplicationLog = 2,
            CantPersistApplicationState = 3
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Title = "这是通过OnStartup事件启动的窗口";
            win.Show();

            //Window2 win2 = new Window2();
            //win2.Title = "在OnStartup 事件中打开的第二个窗口";
            //win2.Show();
        }

        protected override void OnActivated(EventArgs e)
        {
            Debug.Write("当前应用程序被激活\r\n");
            foreach (Window win in Windows)
            {
                if (win.IsActive)
                {
                    Debug.Write("当前的活动窗口是:\r\n" +
                        win.Title);
                }
            }
            base.OnActivated(e);
        }

        protected override void OnDeactivated(EventArgs e)
        {
            base.OnDeactivated(e);
            Debug.Write("当前应用程序停止激活\r\n");
        }

        private void Application_DispatcherUnhandledException_1(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            string err = "异常信息为: " + e.Exception.Message;
            MessageBox.Show(err, "Express", MessageBoxButton.OK);
            e.Handled = true;
        }

        private void OnSessionEnding(object sender, SessionEndingCancelEventArgs e)
        {
            string msg = string.Format("{0}.是否要终止Windows 回话?", e.ReasonSessionEnding);
            MessageBoxResult result = MessageBox.Show(msg, "Session Ending", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void OnExit(object sender, ExitEventArgs e)
        {
            try
            {
                if (e.ApplicationExitCode == (int)ApplicationExitCode.Success)
                    WriteApplicationLogEntry("Failure", e.ApplicationExitCode);
                else
                    WriteApplicationLogEntry("Success", e.ApplicationExitCode);

            }
            catch
            {
                e.ApplicationExitCode = (int)ApplicationExitCode.CantPersistApplicationState;
            }

            try
            {
                PersitApplicationState();
            }
            catch
            {
                e.ApplicationExitCode = (int)ApplicationExitCode.CantPersistApplicationState;
            }
        }

        void WriteApplicationLogEntry(string message, int exitCode)
        {
            //File path
            //C:\Users\leahd\AppData\Local\IsolatedStorage\kww5ns3k.v3r\znsu2c14.nmx\Url.tabn2jkjtldwuxix102dtacrvufhcrgu\AssemFiles
            IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForAssembly();
            using (Stream stream = new IsolatedStorageFileStream("log.txt", FileMode.Append, FileAccess.Write, store))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                string entry = string.Format("{0}: {1} - {2}", message, exitCode, DateTime.Now);
                writer.WriteLine(entry);
            }
        }

        void PersitApplicationState()
        {
            //File path
            //C:\Users\leahd\AppData\Local\IsolatedStorage\kww5ns3k.v3r\znsu2c14.nmx\Url.tabn2jkjtldwuxix102dtacrvufhcrgu\AssemFiles
            IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForAssembly();
            using (Stream stream = new IsolatedStorageFileStream("state.txt", FileMode.Create, store))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                foreach (DictionaryEntry entry in this.Properties)
                {
                    writer.WriteLine(entry.Value);
                }
            }
        }
    }
}
