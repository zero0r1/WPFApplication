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
    /// DragandDropSimpleDemo.xaml 的交互逻辑
    /// </summary>
    public partial class DragandDropSimpleDemo : Window
    {
        public DragandDropSimpleDemo()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtDisplayFileContents.Text = string.Empty;
        }

        private void cbWrap_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtDisplayFileContents_PreviewDragOver(object sender, DragEventArgs e)
        {
            if (IsSingleFile(e) != null)
                e.Effects = DragDropEffects.Copy;
            else
                e.Effects = DragDropEffects.None;

            e.Handled = true;
        }

        private void txtDisplayFileContents_PreviewDrop(object sender, DragEventArgs e)
        {
            e.Handled = true;
            string fileName = IsSingleFile(e);
            if (fileName == null) return;

            StreamReader fileToload = new StreamReader(fileName, Encoding.Default);
            txtDisplayFileContents.Text = fileToload.ReadToEnd();
            fileToload.Close();
            this.Title = "加载文件: " + fileName;
        }

        string IsSingleFile(DragEventArgs args)
        {
            if (args.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                string[] fileNames = args.Data.GetData(DataFormats.FileDrop, true) as string[];
                if (fileNames.Length == 1)
                {
                    if (File.Exists(fileNames[0]))
                        return fileNames[0];

                }
            }

            return null;
        }
    }
}
