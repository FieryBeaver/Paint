﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "375ED466F82A1FD63EBB2EE3FA117789653C6CABAA7F662AA1245248E26080E9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.InkCanvas inkCanvas1;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ItemOpen;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ItemSave;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ItemExport;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ItemExit;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Clear;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Palette;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Pen;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Ereser;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EreseStroke;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EresePoint;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Rectangle;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Select;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.inkCanvas1 = ((System.Windows.Controls.InkCanvas)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.inkCanvas1.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.inkCanvas1_MouseDown);
            
            #line default
            #line hidden
            
            #line 24 "..\..\MainWindow.xaml"
            this.inkCanvas1.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.inkCanvas1_MouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ItemOpen = ((System.Windows.Controls.MenuItem)(target));
            
            #line 28 "..\..\MainWindow.xaml"
            this.ItemOpen.Click += new System.Windows.RoutedEventHandler(this.ItemOpen_Click);
            
            #line default
            #line hidden
            
            #line 28 "..\..\MainWindow.xaml"
            this.ItemOpen.MouseEnter += new System.Windows.Input.MouseEventHandler(this.AboutOpen_Enter);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ItemSave = ((System.Windows.Controls.MenuItem)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.ItemSave.Click += new System.Windows.RoutedEventHandler(this.ItemSave_Click);
            
            #line default
            #line hidden
            
            #line 30 "..\..\MainWindow.xaml"
            this.ItemSave.MouseEnter += new System.Windows.Input.MouseEventHandler(this.AboutSave_Enter);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ItemExport = ((System.Windows.Controls.MenuItem)(target));
            
            #line 32 "..\..\MainWindow.xaml"
            this.ItemExport.Click += new System.Windows.RoutedEventHandler(this.ItemExport_Click);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MainWindow.xaml"
            this.ItemExport.MouseEnter += new System.Windows.Input.MouseEventHandler(this.AboutExport_Enter);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ItemExit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.ItemExit.Click += new System.Windows.RoutedEventHandler(this.ItemExit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Clear = ((System.Windows.Controls.MenuItem)(target));
            
            #line 37 "..\..\MainWindow.xaml"
            this.Clear.Click += new System.Windows.RoutedEventHandler(this.EditClear_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Palette = ((System.Windows.Controls.MenuItem)(target));
            
            #line 41 "..\..\MainWindow.xaml"
            this.Palette.Click += new System.Windows.RoutedEventHandler(this.ToolsOpen_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Pen = ((System.Windows.Controls.MenuItem)(target));
            
            #line 42 "..\..\MainWindow.xaml"
            this.Pen.Click += new System.Windows.RoutedEventHandler(this.Pen_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Ereser = ((System.Windows.Controls.MenuItem)(target));
            
            #line 43 "..\..\MainWindow.xaml"
            this.Ereser.Click += new System.Windows.RoutedEventHandler(this.Ereser_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.EreseStroke = ((System.Windows.Controls.MenuItem)(target));
            
            #line 44 "..\..\MainWindow.xaml"
            this.EreseStroke.Click += new System.Windows.RoutedEventHandler(this.EreseStroke_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.EresePoint = ((System.Windows.Controls.MenuItem)(target));
            
            #line 45 "..\..\MainWindow.xaml"
            this.EresePoint.Click += new System.Windows.RoutedEventHandler(this.EresePoint_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Rectangle = ((System.Windows.Controls.MenuItem)(target));
            
            #line 49 "..\..\MainWindow.xaml"
            this.Rectangle.Click += new System.Windows.RoutedEventHandler(this.Rectangle_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Select = ((System.Windows.Controls.MenuItem)(target));
            
            #line 51 "..\..\MainWindow.xaml"
            this.Select.Click += new System.Windows.RoutedEventHandler(this.Select_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

