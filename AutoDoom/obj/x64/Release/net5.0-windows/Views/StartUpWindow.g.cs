﻿#pragma checksum "..\..\..\..\..\Views\StartUpWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1A2E11F0F5BF80A91CB844EB6396FA06C4BBFA46"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoDoom.Views;
using Prism.Interactivity;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Regions.Behaviors;
using Prism.Services.Dialogs;
using Prism.Unity;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace AutoDoom.Views {
    
    
    /// <summary>
    /// StartUpWindow
    /// </summary>
    public partial class StartUpWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\..\..\Views\StartUpWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenProjectButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\Views\StartUpWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseProjectButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\Views\StartUpWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox StartCheckBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\..\Views\StartUpWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox HelpCheckBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\Views\StartUpWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SettingsCheckBox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\..\Views\StartUpWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TopBarGrid;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\Views\StartUpWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TopBarCloseButton;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\Views\StartUpWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TopBarScaleButton;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\..\Views\StartUpWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TopBarMinimizeButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AutoDoom;component/views/startupwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\StartUpWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.OpenProjectButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\..\Views\StartUpWindow.xaml"
            this.OpenProjectButton.Click += new System.Windows.RoutedEventHandler(this.OpenProjectButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CloseProjectButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.StartCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.HelpCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.SettingsCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.TopBarGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 59 "..\..\..\..\..\Views\StartUpWindow.xaml"
            this.TopBarGrid.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TopBarGrid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TopBarCloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\..\..\Views\StartUpWindow.xaml"
            this.TopBarCloseButton.Click += new System.Windows.RoutedEventHandler(this.TopBarCloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TopBarScaleButton = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\..\Views\StartUpWindow.xaml"
            this.TopBarScaleButton.Click += new System.Windows.RoutedEventHandler(this.TopBarScaleButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TopBarMinimizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\..\..\Views\StartUpWindow.xaml"
            this.TopBarMinimizeButton.Click += new System.Windows.RoutedEventHandler(this.TopBarMinimizeButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
