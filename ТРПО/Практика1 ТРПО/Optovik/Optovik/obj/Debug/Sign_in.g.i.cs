﻿#pragma checksum "..\..\Sign_in.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2C777B8F75354ABEA5289EA94DFF195D12D897C2234468F5CADF3BB447477A56"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Optovik;
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


namespace Optovik {
    
    
    /// <summary>
    /// Sign_in
    /// </summary>
    public partial class Sign_in : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 68 "..\..\Sign_in.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginTextBox;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\Sign_in.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordBox;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\Sign_in.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\Sign_in.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox showPassword;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\Sign_in.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sign_In_BTN;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Sign_in.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Registration_BTN;
        
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
            System.Uri resourceLocater = new System.Uri("/Optovik;component/sign_in.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Sign_in.xaml"
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
            this.loginTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.passwordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.tb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.showPassword = ((System.Windows.Controls.CheckBox)(target));
            
            #line 72 "..\..\Sign_in.xaml"
            this.showPassword.Unchecked += new System.Windows.RoutedEventHandler(this.ShowPassword_Unchecked);
            
            #line default
            #line hidden
            
            #line 72 "..\..\Sign_in.xaml"
            this.showPassword.Checked += new System.Windows.RoutedEventHandler(this.ShowPassword_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Sign_In_BTN = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\Sign_in.xaml"
            this.Sign_In_BTN.Click += new System.Windows.RoutedEventHandler(this.Sign_In_BTN_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Registration_BTN = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\Sign_in.xaml"
            this.Registration_BTN.Click += new System.Windows.RoutedEventHandler(this.Registration_BTN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

