using System;
using System.Collections.Generic;
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
    /// AttachedEventDemo.xaml 的交互逻辑
    /// </summary>
    public partial class AttachedEventDemo : Window
    {
        public AttachedEventDemo()
        {
            InitializeComponent();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button)
            {
                MessageBox.Show(((Button)e.Source).Content.ToString());
            }
        }
    }
}
