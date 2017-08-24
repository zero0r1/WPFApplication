using SingleInstanceWithCommunicationhCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInstanceWithCommunication
{
    public class Startup
    {
        [STAThread]
        public static void Main(string[] args)
        {
            SingleApplicationBase sab = new SingleApplicationBase();
            sab.Run(args);
        }
    }
}
