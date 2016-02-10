﻿#pragma checksum "..\..\..\TabView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8F608CC000A81250BB6ECDCCBBF1A3B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CefSharp;
using CefSharp.Wpf;
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
using WebExpress;


namespace WebExpress {
    
    
    /// <summary>
    /// TabView
    /// </summary>
    public partial class TabView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\TabView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Panel;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\TabView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\TabView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\TabView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Forward;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\TabView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Refresh;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\TabView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CefSharp.Wpf.ChromiumWebBrowser WebView;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\TabView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ListContainer;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\TabView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox;
        
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
            System.Uri resourceLocater = new System.Uri("/WebExpress;component/tabview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TabView.xaml"
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
            this.Panel = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.textBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\TabView.xaml"
            this.textBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.textBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\TabView.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Forward = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\TabView.xaml"
            this.Forward.Click += new System.Windows.RoutedEventHandler(this.Forward_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Refresh = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\TabView.xaml"
            this.Refresh.Click += new System.Windows.RoutedEventHandler(this.Refresh_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.WebView = ((CefSharp.Wpf.ChromiumWebBrowser)(target));
            
            #line 33 "..\..\..\TabView.xaml"
            this.WebView.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WebView_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ListContainer = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.listBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 40 "..\..\..\TabView.xaml"
            this.listBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBox_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\TabView.xaml"
            this.listBox.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.listBox_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
