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
    /// UnderstandingDp.xaml 的交互逻辑
    /// </summary>
    public partial class UnderstandingDp : Window
    {
        public UnderstandingDp()
        {
            InitializeComponent();
        }

        private void btnWindowsSize_Click(object sender, RoutedEventArgs e)
        {
            this.FontSize = 20;
        }

        private void btnButtonSize_Click(object sender, RoutedEventArgs e)
        {
            txt.FontSize = 10;
        }
    }
}
