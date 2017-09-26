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

namespace WPFlayout.ContentControl2
{
    /// <summary>
    /// ButtonBaseDemo.xaml 的交互逻辑
    /// </summary>
    public partial class ButtonBaseDemo : Window
    {
        public ButtonBaseDemo()
        {
            InitializeComponent();
        }

        //当鼠标经过按钮时
        void OnClick1(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.LightBlue;
            MessageBox.Show("btn1触发了单击事件");
        }
        //当鼠标按下时
        void OnClick2(object sender, RoutedEventArgs e)
        {
            btn2.Background = Brushes.Pink;
            MessageBox.Show("btn2触发了单击事件");
        }
        //当鼠标释放时
        void OnClick3(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.Pink;
            btn2.Background = Brushes.LightBlue;
            MessageBox.Show("btn3触发了单击事件");
        }
    }
}
