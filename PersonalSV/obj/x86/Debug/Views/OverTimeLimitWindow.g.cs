﻿#pragma checksum "..\..\..\..\Views\OverTimeLimitWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "54D279C80D81F035EEE3609BBB63F11A2796575CC1C8079B58B40837EE497164"
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
    /// LeavWithSalaryWindow
    /// </summary>
    public partial class LeavWithSalaryWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmployeeSearch;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridOTInfor;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDateFrom;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDateTo;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView treeDepartments;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgEmployeePerDepartment;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miRemove;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTotal;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/PersonalSV;component/views/overtimelimitwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
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
            
            #line 4 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
            ((PersonalSV.Views.LeavWithSalaryWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtEmployeeSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
            this.txtEmployeeSearch.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.txtEmployeeSearch_PreviewKeyUp);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
            this.txtEmployeeSearch.PreviewGotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.txtEmployeeSearch_PreviewGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gridOTInfor = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.dpDateFrom = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.dpDateTo = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            
            #line 85 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewGotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_PreviewGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.treeDepartments = ((System.Windows.Controls.TreeView)(target));
            return;
            case 9:
            this.dgEmployeePerDepartment = ((System.Windows.Controls.DataGrid)(target));
            
            #line 95 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
            this.dgEmployeePerDepartment.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.dgEmployeePerDepartment_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 10:
            this.miRemove = ((System.Windows.Controls.MenuItem)(target));
            
            #line 98 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
            this.miRemove.Click += new System.Windows.RoutedEventHandler(this.miRemove_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtTotal = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 138 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 150 "..\..\..\..\Views\OverTimeLimitWindow.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
