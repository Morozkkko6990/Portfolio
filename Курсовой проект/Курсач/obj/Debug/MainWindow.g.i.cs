﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "856FD5B2E8A2A0408B364FF476310CB08FF7C50C1C852E66A7CDC96ECC03D53C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using Курсач;


namespace Курсач {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox login_TB;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox password_TB;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox showPassword;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button login_in;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sign_in;
        
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
            System.Uri resourceLocater = new System.Uri("/Курсач;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.login_TB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.password_TB = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 51 "..\..\MainWindow.xaml"
            this.password_TB.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.PasswordBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tb = ((System.Windows.Controls.TextBox)(target));
            
            #line 52 "..\..\MainWindow.xaml"
            this.tb.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.showPassword = ((System.Windows.Controls.CheckBox)(target));
            
            #line 53 "..\..\MainWindow.xaml"
            this.showPassword.Unchecked += new System.Windows.RoutedEventHandler(this.ShowPassword_Unchecked);
            
            #line default
            #line hidden
            
            #line 53 "..\..\MainWindow.xaml"
            this.showPassword.Checked += new System.Windows.RoutedEventHandler(this.ShowPassword_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.login_in = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\MainWindow.xaml"
            this.login_in.Click += new System.Windows.RoutedEventHandler(this.login_in_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Sign_in = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\MainWindow.xaml"
            this.Sign_in.Click += new System.Windows.RoutedEventHandler(this.Sign_in_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

