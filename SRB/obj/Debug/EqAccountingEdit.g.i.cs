﻿#pragma checksum "..\..\EqAccountingEdit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CFBF9D478D17EF5F8E76D97D95D9AED5843D0BE40D95E3DBFA1B65C0E0885ADF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SRB;
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


namespace SRB {
    
    
    /// <summary>
    /// EqAccountingEdit
    /// </summary>
    public partial class EqAccountingEdit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\EqAccountingEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AccountingGrid;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\EqAccountingEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox equipmentNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\EqAccountingEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox equipmentDepartTextbox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\EqAccountingEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox equipmentMoneyTextBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\EqAccountingEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox equipmentCountTextBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\EqAccountingEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker equipmentDateTextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\EqAccountingEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditBtn;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\EqAccountingEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox equipmentProvTextBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\EqAccountingEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/SRB;component/eqaccountingedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EqAccountingEdit.xaml"
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
            this.AccountingGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 10 "..\..\EqAccountingEdit.xaml"
            this.AccountingGrid.Loaded += new System.Windows.RoutedEventHandler(this.AccountingGrid_Loaded);
            
            #line default
            #line hidden
            
            #line 10 "..\..\EqAccountingEdit.xaml"
            this.AccountingGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AccountingGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.equipmentNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.equipmentDepartTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.equipmentMoneyTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.equipmentCountTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.equipmentDateTextBox = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.EditBtn = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\EqAccountingEdit.xaml"
            this.EditBtn.Click += new System.Windows.RoutedEventHandler(this.EditBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.equipmentProvTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ExitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\EqAccountingEdit.xaml"
            this.ExitBtn.Click += new System.Windows.RoutedEventHandler(this.ExitBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

