#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3963848E4FDB0224E161B17D3569AAB1513360ECCC52069851CBA3BCCB350540"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 193 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Учёт;
        
        #line default
        #line hidden
        
        
        #line 205 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AccBtn;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FeedbackBtn;
        
        #line default
        #line hidden
        
        
        #line 268 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popup_uc;
        
        #line default
        #line hidden
        
        
        #line 274 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SRB.PopupUserControl Header;
        
        #line default
        #line hidden
        
        
        #line 281 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
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
            System.Uri resourceLocater = new System.Uri("/SRB;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.Учёт = ((System.Windows.Controls.Button)(target));
            
            #line 197 "..\..\MainWindow.xaml"
            this.Учёт.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Учёт_MouseEnter);
            
            #line default
            #line hidden
            
            #line 197 "..\..\MainWindow.xaml"
            this.Учёт.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Учёт_MouseLeave);
            
            #line default
            #line hidden
            
            #line 197 "..\..\MainWindow.xaml"
            this.Учёт.Click += new System.Windows.RoutedEventHandler(this.Учёт_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AccBtn = ((System.Windows.Controls.Button)(target));
            
            #line 209 "..\..\MainWindow.xaml"
            this.AccBtn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Сотрудники_MouseEnter);
            
            #line default
            #line hidden
            
            #line 209 "..\..\MainWindow.xaml"
            this.AccBtn.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Сотрудники_MouseLeave);
            
            #line default
            #line hidden
            
            #line 209 "..\..\MainWindow.xaml"
            this.AccBtn.Click += new System.Windows.RoutedEventHandler(this.AccBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FeedbackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 220 "..\..\MainWindow.xaml"
            this.FeedbackBtn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.FeedbackBtn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 220 "..\..\MainWindow.xaml"
            this.FeedbackBtn.MouseLeave += new System.Windows.Input.MouseEventHandler(this.FeedbackBtn_MouseLeave);
            
            #line default
            #line hidden
            
            #line 220 "..\..\MainWindow.xaml"
            this.FeedbackBtn.Click += new System.Windows.RoutedEventHandler(this.FeedbackBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 248 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.popup_uc = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 6:
            this.Header = ((SRB.PopupUserControl)(target));
            return;
            case 7:
            this.Main = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

