﻿#pragma checksum "..\..\..\..\Views\RecordTimeDetailWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71A3C04ED442FAC10733A642D241A1A4EBD33EE6"
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


namespace PersonalSV.Views {
    
    
    /// <summary>
    /// RecordTimeDetailWindow
    /// </summary>
    public partial class RecordTimeDetailWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridEmployeeInfor;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmployeeCode;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmployeeName;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDepartmentName;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRecordTimeAdd;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddTime;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgRecordTime;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miRemove;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/PersonalSV;component/views/recordtimedetailwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
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
            
            #line 3 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
            ((PersonalSV.Views.RecordTimeDetailWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 4 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
            ((PersonalSV.Views.RecordTimeDetailWindow)(target)).KeyUp += new System.Windows.Input.KeyEventHandler(this.Window_KeyUp);
            
            #line default
            #line hidden
            
            #line 4 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
            ((PersonalSV.Views.RecordTimeDetailWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridEmployeeInfor = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.txtEmployeeCode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtEmployeeName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtDepartmentName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtRecordTimeAdd = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
            this.txtRecordTimeAdd.PreviewGotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.txtRecordTimeAdd_PreviewGotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
            this.txtRecordTimeAdd.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.txtRecordTimeAdd_PreviewKeyUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnAddTime = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
            this.btnAddTime.Click += new System.Windows.RoutedEventHandler(this.btnAddTime_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dgRecordTime = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.miRemove = ((System.Windows.Controls.MenuItem)(target));
            
            #line 70 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
            this.miRemove.Click += new System.Windows.RoutedEventHandler(this.miRemove_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\..\Views\RecordTimeDetailWindow.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

