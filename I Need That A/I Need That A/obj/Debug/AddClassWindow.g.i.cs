﻿#pragma checksum "..\..\AddClassWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "110A4718109B4C9E6333CF3DB217C65E3EE93ACD"
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


namespace I_Need_That_A {
    
    
    /// <summary>
    /// AddClassWindow
    /// </summary>
    public partial class AddClassWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbxClassName;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbxUnits;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbxDaySched;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbxTimeSchedFromHour;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbxTimeSchedFromMinute;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbxTimeSchedToHour;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbxTimeSchedToMinute;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbTimeSchedType;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbxProfessor;
        
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
            System.Uri resourceLocater = new System.Uri("/I Need That A;component/addclasswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddClassWindow.xaml"
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
            
            #line 4 "..\..\AddClassWindow.xaml"
            ((I_Need_That_A.AddClassWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\AddClassWindow.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\AddClassWindow.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TbxClassName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TbxUnits = ((System.Windows.Controls.TextBox)(target));
            
            #line 81 "..\..\AddClassWindow.xaml"
            this.TbxUnits.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbxUnits_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TbxDaySched = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TbxTimeSchedFromHour = ((System.Windows.Controls.TextBox)(target));
            
            #line 110 "..\..\AddClassWindow.xaml"
            this.TbxTimeSchedFromHour.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbxTimeSchedFromHour_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TbxTimeSchedFromMinute = ((System.Windows.Controls.TextBox)(target));
            
            #line 117 "..\..\AddClassWindow.xaml"
            this.TbxTimeSchedFromMinute.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbxTimeSchedFromMinute_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TbxTimeSchedToHour = ((System.Windows.Controls.TextBox)(target));
            
            #line 124 "..\..\AddClassWindow.xaml"
            this.TbxTimeSchedToHour.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbxTimeSchedToHour_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.TbxTimeSchedToMinute = ((System.Windows.Controls.TextBox)(target));
            
            #line 131 "..\..\AddClassWindow.xaml"
            this.TbxTimeSchedToMinute.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbxTimeSchedToMinute_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.CmbTimeSchedType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.TbxProfessor = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

