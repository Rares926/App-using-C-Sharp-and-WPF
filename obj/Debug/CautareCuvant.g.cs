﻿#pragma checksum "..\..\CautareCuvant.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FC7377D7F3147AEA8B95A03B7A1BB61A3A607B9CC8303C7EF9F7407697FBD757"
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
using Tema_MVP_Dictionar;


namespace Tema_MVP_Dictionar {
    
    
    /// <summary>
    /// CautareCuvant
    /// </summary>
    public partial class CautareCuvant : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\CautareCuvant.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn1;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\CautareCuvant.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ForCategory;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\CautareCuvant.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ForDefinition;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\CautareCuvant.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ForWords;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\CautareCuvant.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBar;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\CautareCuvant.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listToComplete;
        
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
            System.Uri resourceLocater = new System.Uri("/Tema_MVP_Dictionar;component/cautarecuvant.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CautareCuvant.xaml"
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
            this.btn1 = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\CautareCuvant.xaml"
            this.btn1.Click += new System.Windows.RoutedEventHandler(this.btn1_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ForCategory = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\CautareCuvant.xaml"
            this.ForCategory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ForCategory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ForDefinition = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ForWords = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.searchBar = ((System.Windows.Controls.TextBox)(target));
            
            #line 111 "..\..\CautareCuvant.xaml"
            this.searchBar.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchBar_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.listToComplete = ((System.Windows.Controls.ListView)(target));
            
            #line 120 "..\..\CautareCuvant.xaml"
            this.listToComplete.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listToComplete_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
