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

namespace SingleInstanceWithCommunication
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public void LoadFile(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    string txt = File.ReadAllText(fileName);
                    this.txtContent.Text = txt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载文档失败! 失败消息是: " + ex.Message);
            }
        }
    }
}
