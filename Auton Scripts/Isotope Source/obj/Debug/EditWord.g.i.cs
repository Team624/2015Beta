﻿#pragma checksum "..\..\EditWord.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B3FD775BE2BCBA5188D50EA9C6871020"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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
using System.Windows.Forms.Integration;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Isotope {
    
    
    /// <summary>
    /// EditWord
    /// </summary>
    public partial class EditWord : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\EditWord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox wordBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\EditWord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker ColorPicker;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\EditWord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox bold;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\EditWord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox italic;
        
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
            System.Uri resourceLocater = new System.Uri("/Isotope;component/editword.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditWord.xaml"
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
            this.wordBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ColorPicker = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            return;
            case 3:
            
            #line 55 "..\..\EditWord.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.save_word);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bold = ((System.Windows.Controls.CheckBox)(target));
            
            #line 64 "..\..\EditWord.xaml"
            this.bold.Checked += new System.Windows.RoutedEventHandler(this.bold_c);
            
            #line default
            #line hidden
            
            #line 65 "..\..\EditWord.xaml"
            this.bold.Unchecked += new System.Windows.RoutedEventHandler(this.bold_uc);
            
            #line default
            #line hidden
            return;
            case 5:
            this.italic = ((System.Windows.Controls.CheckBox)(target));
            
            #line 72 "..\..\EditWord.xaml"
            this.italic.Checked += new System.Windows.RoutedEventHandler(this.italic_c);
            
            #line default
            #line hidden
            
            #line 73 "..\..\EditWord.xaml"
            this.italic.Unchecked += new System.Windows.RoutedEventHandler(this.italic_uc);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

