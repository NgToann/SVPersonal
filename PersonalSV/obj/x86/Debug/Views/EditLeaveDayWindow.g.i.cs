﻿#pragma checksum "..\..\..\..\Views\EditLeaveDayWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D8446A29AB388FE21517ED84D581209A4FCF14E4856A9B46F0093DF656D047F2"
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
    /// EditLeaveDayWindow
    /// </summary>
    public partial class EditLeaveDayWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox gridLeaveDay;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDateFrom;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDateTo;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTotalDay;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRemark;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radPaidLeave;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radNotPaidLeave;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgLeaveDay;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/PersonalSV;component/views/editleavedaywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
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
            
            #line 3 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
            ((PersonalSV.Views.EditLeaveDayWindow)(target)).KeyUp += new System.Windows.Input.KeyEventHandler(this.Window_KeyUp);
            
            #line default
            #line hidden
            
            #line 3 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
            ((PersonalSV.Views.EditLeaveDayWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 4 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
            ((PersonalSV.Views.EditLeaveDayWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridLeaveDay = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 3:
            this.dpDateFrom = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.dpDateTo = ((System.Windows.Controls.DatePicker)(target));
            
            #line 35 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
            this.dpDateTo.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dpDateTo_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtTotalDay = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
            this.txtTotalDay.PreviewGotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.txtTotalDay_PreviewGotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
            this.txtTotalDay.PreviewLostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.txtTotalDay_PreviewLostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtRemark = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.radPaidLeave = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.radNotPaidLeave = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dgLeaveDay = ((System.Windows.Controls.DataGrid)(target));
            
            #line 89 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
            this.dgLeaveDay.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.dgLeaveDay_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 170 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 182 "..\..\..\..\Views\EditLeaveDayWindow.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

