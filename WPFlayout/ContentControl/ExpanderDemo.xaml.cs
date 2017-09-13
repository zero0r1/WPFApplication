using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFlayout.ContentControl
{
    /// <summary>
    /// ExpanderDemo.xaml 的交互逻辑
    /// </summary>
    public partial class ExpanderDemo : Window
    {
        public ExpanderDemo()
        {
            InitializeComponent();
        }

        string _fileName = "ExpanderDemo.txt";

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            string filePath = WPFlayout.Global.GetWorkPath(_fileName);
            string content = File.ReadAllText(filePath, Encoding.Default);
            txt1.Text = DateTime.Now.ToString();
            txt1.Text += "\r\n" + content;
        }
    }
}
