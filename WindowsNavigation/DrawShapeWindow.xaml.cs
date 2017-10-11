﻿using System;
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
    /// DrawShapeWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DrawShapeWindow : Window
    {
        public DrawShapeWindow()
        {
            InitializeComponent();
        }

        void NonRectangularWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //允许使用在窗口工作区的暴露区域上方按下其鼠标左键的鼠标来拖动窗口。
            this.DragMove();
        }

        void closeButtonRectangle_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
