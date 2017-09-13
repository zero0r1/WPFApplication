using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFlayout
{
    public class Global
    {

        public static string GetWorkPath(string path)
        {
            return System.IO.Path.Combine(Environment.CurrentDirectory + "\\..\\..\\Resources", path);
        }
    }
}
