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

namespace WPFlayout
{
    /// <summary>
    /// GridDialogBoxByCode.xaml 的交互逻辑
    /// </summary>
    public partial class GridDialogBoxByCode : Window
    {
        public GridDialogBoxByCode()
        {
            InitializeComponent();
            this.Content = this.CreateGrid();
        }

        Grid CreateGrid()
        {
            //实例化一个Grid对象
            Grid grd = new Grid();
            //定义第一行
            RowDefinition row1 = new RowDefinition();

            //行的Height 和列的Weigth都是GridLength类型的对象. 
            //改对象有三个重载的构造函数, 分别对应到Grid 空间的尺寸模式. 
            //这里的GridUnitType.Start 类指定尺寸单位, Start 在XAML中就是一个* 号
            row1.Height = new GridLength(1, GridUnitType.Star);
            grd.RowDefinitions.Add(row1);

            RowDefinition row2 = new RowDefinition();
            row2.Height = GridLength.Auto;
            grd.RowDefinitions.Add(row2);

            //创建一个 TextBox 对象
            TextBox txt = new TextBox();
            txt.Text = "这个是一个对话窗口, RowDefinition 的Height 属性被设置为*, 那么TextBox将占用剩余的空间.";
            txt.TextWrapping = TextWrapping.Wrap;

            //使用 Grid 控件的附件属性设置 TextBox 控件在 Grid 中的位置
            Grid.SetRow(txt, 0);
            Grid.SetColumn(txt, 0);
            grd.Children.Add(txt);

            //创建 StackPanel 对象
            StackPanel stk = new StackPanel();
            stk.Orientation = Orientation.Horizontal;
            stk.HorizontalAlignment = HorizontalAlignment.Right;

            //使用附加属性指定该控件位于 Grid 的第二行
            Grid.SetRow(stk, 1);
            Grid.SetColumn(stk, 0);
            grd.Children.Add(stk);

            //创建"确定"按钮并添加到StackPanel控件中
            Button btn1 = new Button();
            btn1.Margin = new Thickness(10, 10, 2, 10);
            btn1.Content = "确定";
            btn1.Padding = new Thickness(3);
            stk.Children.Add(btn1);

            //创建"取消"按钮并添加到StackPanel控件中
            Button btn2 = new Button();
            btn2.Margin = new Thickness(2, 10, 10, 10);
            btn2.Content = "取消";
            btn2.Padding = new Thickness(3);
            stk.Children.Add(btn2);
            return grd;
        }
    }
}
