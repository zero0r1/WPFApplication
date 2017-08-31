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
    /// InkCanvasDemo.xaml 的交互逻辑
    /// </summary>
    public partial class InkCanvasDemo : Window
    {
        public InkCanvasDemo()
        {
            InitializeComponent();

            this.Width = 600;
            this.Height = 600;
        }

        private void cb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (inkCanvas == null)
                return;

            string itemText = ((ComboBoxItem)cb1.SelectedItem).Content.ToString();
            inkCanvas.EditingMode = ParseEnum<InkCanvasEditingMode>(itemText);
        }

        public T ParseEnum<T>(string text)
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException(typeof(T).ToString() + "这不是一个枚举值");
            }
            T t = (T)Enum.Parse(typeof(T), text, true);
            return t;
        }
    }
}
