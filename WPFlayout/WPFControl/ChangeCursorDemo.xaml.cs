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

namespace WPFlayout.WPFControl
{
    /// <summary>
    /// ChangeCursorDemo.xaml 的交互逻辑
    /// </summary>
    public partial class ChangeCursorDemo : Window
    {
        /// <summary>
        /// 自定义光标
        /// </summary>
        Cursor CustomCursor;

        /// <summary>
        /// 用于指定光标范围的布尔值
        /// </summary>
        bool _cursorScopeElementOnly = true;

        public ChangeCursorDemo()
        {
            InitializeComponent();

            CustomCursor = new Cursor(Global.GetWorkPath("CustomCursor.cur"));
        }

        private void CursorTypeChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox source = e.Source as ComboBox;
            //当用户选择不同的光标类型时，设置Border控件的光标
            if (source != null)
            {
                ComboBoxItem selectedCursor = source.SelectedItem as ComboBoxItem;
                switch (selectedCursor.Content.ToString())
                {
                    case "AppStarting":
                        DisplayArea.Cursor = Cursors.AppStarting;
                        break;
                    case "ArrowCD":
                        DisplayArea.Cursor = Cursors.ArrowCD;
                        break;
                    case "Arrow":
                        DisplayArea.Cursor = Cursors.Arrow;
                        break;
                    case "Cross":
                        DisplayArea.Cursor = Cursors.Cross;
                        break;
                    case "HandCursor":
                        DisplayArea.Cursor = Cursors.Hand;
                        break;
                    case "Help":
                        DisplayArea.Cursor = Cursors.Help;
                        break;
                    case "IBeam":
                        DisplayArea.Cursor = Cursors.IBeam;
                        break;
                    case "No":
                        DisplayArea.Cursor = Cursors.No;
                        break;
                    case "None":
                        DisplayArea.Cursor = Cursors.None;
                        break;
                    case "Pen":
                        DisplayArea.Cursor = Cursors.Pen;
                        break;
                    case "ScrollSE":
                        DisplayArea.Cursor = Cursors.ScrollSE;
                        break;
                    case "ScrollWE":
                        DisplayArea.Cursor = Cursors.ScrollWE;
                        break;
                    case "SizeAll":
                        DisplayArea.Cursor = Cursors.SizeAll;
                        break;
                    case "SizeNESW":
                        DisplayArea.Cursor = Cursors.SizeNESW;
                        break;
                    case "SizeNS":
                        DisplayArea.Cursor = Cursors.SizeNS;
                        break;
                    case "SizeNWSE":
                        DisplayArea.Cursor = Cursors.SizeNWSE;
                        break;
                    case "SizeWE":
                        DisplayArea.Cursor = Cursors.SizeWE;
                        break;
                    case "UpArrow":
                        DisplayArea.Cursor = Cursors.UpArrow;
                        break;
                    case "WaitCursor":
                        DisplayArea.Cursor = Cursors.Wait;
                        break;
                    case "Custom":
                        DisplayArea.Cursor = CustomCursor;
                        break;
                    default:
                        break;
                }
                //如果光标范围选择为整个应用程序，则使用Mouse.OverrideCursor属性设置光标
                if (_cursorScopeElementOnly == false)
                {
                    Mouse.OverrideCursor = DisplayArea.Cursor;
                }
            }
        }

        // 确定光标范围
        public void CursorScopeSelected(object sender, RoutedEventArgs e)
        {
            RadioButton source = e.Source as RadioButton;
            if (source != null)
            {
                if (source.Name == "rbScopeElement")
                {
                    // 仅为当前元素设置光标
                    _cursorScopeElementOnly = true;
                    // 清除应用程序光标
                    Mouse.OverrideCursor = null;

                }
                if (source.Name == "rbScopeApplication")
                {
                    //则为整个应用程序指定光标
                    _cursorScopeElementOnly = false;

                    // 为所有元素强制光标
                    Mouse.OverrideCursor = DisplayArea.Cursor;
                }
            }
        }
        public void OnLoaded(object sender, RoutedEventArgs e)
        {
            // 当UI加载完成时，为ComboBox选中当前默认的光标            
            ((ComboBoxItem)CursorSelector.Items[2]).IsSelected = true;
        }
    }
}
