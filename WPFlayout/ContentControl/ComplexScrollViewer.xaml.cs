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
    /// ComplexScrollViewer.xaml 的交互逻辑
    /// </summary>
    public partial class ComplexScrollViewer : Window
    {
        const string _fileName = "TestFile.txt";

        public ComplexScrollViewer()
        {
            InitializeComponent();
            InitWindows();
        }

        void InitWindows()
        {
            string filePath = WPFlayout.Global.GetWorkPath(_fileName);
            string content = File.ReadAllText(filePath, Encoding.Default);
            txt1.Text = content;
        }

        private void SvlineUp(object sender, RoutedEventArgs e)
        {
            sv1.LineUp();
        }

        private void SvLineDown(object sender, RoutedEventArgs e)
        {
            sv1.LineDown();
        }

        private void SvlineRight(object sender, RoutedEventArgs e)
        {
            sv1.LineRight();
        }

        private void SvlineLeft(object sender, RoutedEventArgs e)
        {
            sv1.LineLeft();
        }

        private void SvPageUp(object sender, RoutedEventArgs e)
        {
            sv1.PageUp();
        }

        private void SvPageDown(object sender, RoutedEventArgs e)
        {
            sv1.PageDown();
        }

        private void SvPageRight(object sender, RoutedEventArgs e)
        {
            sv1.PageRight();
        }

        private void SvPageLeft(object sender, RoutedEventArgs e)
        {
            sv1.PageLeft();
        }
    }
}
