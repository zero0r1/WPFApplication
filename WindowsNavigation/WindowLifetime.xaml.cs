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

namespace WindowsNavigation
{
    /// <summary>
    /// WindowLifetime.xaml 的交互逻辑
    /// </summary>
    public partial class WindowLifetime : Window
    {
        public WindowLifetime()
        {
            InitializeComponent();

            this.LocationChanged += WindowLifetime_LocationChanged;
            this.Activated += WindowLifetime_Activated;
            this.Deactivated += WindowLifetime_Deactivated;
            this.Loaded += WindowLifetime_Loaded;
            this.ContentRendered += WindowLifetime_ContentRendered;
            this.Closed += WindowLifetime_Closed;
            this.Closing += WindowLifetime_Closing;
            this.Unloaded += WindowLifetime_Unloaded;
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            this.txtLifeTime.Text += "Initialized 事件被触发\r\n";
        }

        private void WindowLifetime_Unloaded(object sender, RoutedEventArgs e)
        {
            this.txtLifeTime.Text += "Unloaded 事件被触发\r\n";
        }

        private void WindowLifetime_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.txtLifeTime.Text += "Closing 事件被触发\r\n";

        }

        private void WindowLifetime_Closed(object sender, EventArgs e)
        {
            this.txtLifeTime.Text += "Closed 事件被触发\r\n";
        }

        private void WindowLifetime_ContentRendered(object sender, EventArgs e)
        {
            this.txtLifeTime.Text += "ContentRendered 事件被触发\r\n";
        }

        private void WindowLifetime_Loaded(object sender, RoutedEventArgs e)
        {
            this.txtLifeTime.Text += "Loaded 事件被触发\r\n";
        }

        private void WindowLifetime_Deactivated(object sender, EventArgs e)
        {
            this.txtLifeTime.Text += "Deactivated 事件被触发\r\n";
        }

        private void WindowLifetime_Activated(object sender, EventArgs e)
        {
            this.txtLifeTime.Text += "Activated 事件被触发\r\n";
        }

        private void WindowLifetime_LocationChanged(object sender, EventArgs e)
        {
            this.txtLifeTime.Text += "LocationChanged 事件被触发\r\n";
        }
    }
}
