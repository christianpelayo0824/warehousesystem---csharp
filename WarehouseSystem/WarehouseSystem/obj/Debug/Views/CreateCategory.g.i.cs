﻿#pragma checksum "..\..\..\Views\CreateCategory.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0F959CAC5B4302C59B8E6B83F29FA9BDD56C4AB8"
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


namespace WarehouseSystem {
    
    
    /// <summary>
    /// CreateCategory
    /// </summary>
    public partial class CreateCategory : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Views\CreateCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox categorycode_Textbox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Views\CreateCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox description_Textbox;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Views\CreateCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox type_Textbox;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\Views\CreateCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid create_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/WarehouseSystem;component/views/createcategory.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CreateCategory.xaml"
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
            this.categorycode_Textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.description_Textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.type_Textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.create_Button = ((System.Windows.Controls.Grid)(target));
            
            #line 115 "..\..\..\Views\CreateCategory.xaml"
            this.create_Button.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.create_Button_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 116 "..\..\..\Views\CreateCategory.xaml"
            this.create_Button.MouseEnter += new System.Windows.Input.MouseEventHandler(this.create_Button_MouseEnter);
            
            #line default
            #line hidden
            
            #line 117 "..\..\..\Views\CreateCategory.xaml"
            this.create_Button.MouseLeave += new System.Windows.Input.MouseEventHandler(this.create_Button_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

