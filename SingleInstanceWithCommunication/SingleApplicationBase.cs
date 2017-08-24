using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;

using SingleInstanceWithCommunication;

namespace SingleInstanceWithCommunicationhCommunication
{
    public class SingleApplicationBase : WindowsFormsApplicationBase
    {
        public SingleApplicationBase()
        {
            this.IsSingleInstance = true;
        }

        App wpfApp;
        protected override bool OnStartup(StartupEventArgs eventArgs)
        {
            wpfApp = new App();
            wpfApp.Run();
            return false;
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
        {
            base.OnStartupNextInstance(eventArgs);
            if (eventArgs.CommandLine.Count > 0)
                wpfApp.ShowWindowText(eventArgs.CommandLine[0]);
        }
    }
}