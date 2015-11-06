﻿#pragma checksum "..\..\OptionsWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "07FA59DBE5B73B657762D0147BCBABDF"
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


namespace Isotope {
    
    
    /// <summary>
    /// OptionsWindow
    /// </summary>
    public partial class OptionsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView syntaxList;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView commandList;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView subcommandList;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView aliasList;
        
        #line default
        #line hidden
        
        
        #line 235 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox use_json_cb;
        
        #line default
        #line hidden
        
        
        #line 240 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label file_display;
        
        #line default
        #line hidden
        
        
        #line 248 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loadjsonfile;
        
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
            System.Uri resourceLocater = new System.Uri("/Isotope;component/optionswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OptionsWindow.xaml"
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
            this.syntaxList = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            
            #line 75 "..\..\OptionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.add_word);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 79 "..\..\OptionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.edit_word);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 84 "..\..\OptionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.delete_word_click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 94 "..\..\OptionsWindow.xaml"
            ((System.Windows.Controls.TabItem)(target)).Drop += new System.Windows.DragEventHandler(this.file_drop);
            
            #line default
            #line hidden
            return;
            case 6:
            this.commandList = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.subcommandList = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            
            #line 162 "..\..\OptionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.add_command);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 166 "..\..\OptionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.edit_command);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 171 "..\..\OptionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.delete_click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 176 "..\..\OptionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clear_command);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 182 "..\..\OptionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.add_json_click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 187 "..\..\OptionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.make_json_click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 196 "..\..\OptionsWindow.xaml"
            ((System.Windows.Controls.TabItem)(target)).Drop += new System.Windows.DragEventHandler(this.file_drop);
            
            #line default
            #line hidden
            return;
            case 15:
            this.aliasList = ((System.Windows.Controls.ListView)(target));
            return;
            case 16:
            
            #line 222 "..\..\OptionsWindow.xaml"
            ((System.Windows.Controls.TabItem)(target)).Drop += new System.Windows.DragEventHandler(this.file_drop);
            
            #line default
            #line hidden
            return;
            case 17:
            this.use_json_cb = ((System.Windows.Controls.CheckBox)(target));
            
            #line 234 "..\..\OptionsWindow.xaml"
            this.use_json_cb.Checked += new System.Windows.RoutedEventHandler(this.JSONCheckBoxChanged);
            
            #line default
            #line hidden
            
            #line 234 "..\..\OptionsWindow.xaml"
            this.use_json_cb.Unchecked += new System.Windows.RoutedEventHandler(this.JSONCheckBoxChanged);
            
            #line default
            #line hidden
            return;
            case 18:
            this.file_display = ((System.Windows.Controls.Label)(target));
            return;
            case 19:
            this.loadjsonfile = ((System.Windows.Controls.Button)(target));
            
            #line 249 "..\..\OptionsWindow.xaml"
            this.loadjsonfile.Click += new System.Windows.RoutedEventHandler(this.loadjsonfile_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 268 "..\..\OptionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ok_click);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 274 "..\..\OptionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cancel_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
