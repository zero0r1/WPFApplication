﻿#pragma checksum "..\..\..\ContentControl\UnderstandRoutedEvent.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "12A6F4501F3622285E643A4C31947E60"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPFlayout.ContentControl;


namespace WPFlayout.ContentControl {
    
    
    /// <summary>
    /// UnderstandRoutedEvent
    /// </summary>
    public partial class UnderstandRoutedEvent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\ContentControl\UnderstandRoutedEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\ContentControl\UnderstandRoutedEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\ContentControl\UnderstandRoutedEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stk;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\ContentControl\UnderstandRoutedEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\ContentControl\UnderstandRoutedEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\ContentControl\UnderstandRoutedEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button2;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFlayout;component/contentcontrol/understandroutedevent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ContentControl\UnderstandRoutedEvent.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\ContentControl\UnderstandRoutedEvent.xaml"
            ((WPFlayout.ContentControl.UnderstandRoutedEvent)(target)).AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.button1_Click));
            
            #line default
            #line hidden
            return;
            case 2:
            this.Grid = ((System.Windows.Controls.Grid)(target));
            
            #line 11 "..\..\..\ContentControl\UnderstandRoutedEvent.xaml"
            this.Grid.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.button1_Click));
            
            #line default
            #line hidden
            return;
            case 3:
            this.textBox1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.stk = ((System.Windows.Controls.StackPanel)(target));
            
            #line 18 "..\..\..\ContentControl\UnderstandRoutedEvent.xaml"
            this.stk.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.button1_Click));
            
            #line default
            #line hidden
            return;
            case 5:
            this.button1 = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\ContentControl\UnderstandRoutedEvent.xaml"
            this.button1.Click += new System.Windows.RoutedEventHandler(this.button1_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.button2 = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\ContentControl\UnderstandRoutedEvent.xaml"
            this.button2.Click += new System.Windows.RoutedEventHandler(this.button1_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

