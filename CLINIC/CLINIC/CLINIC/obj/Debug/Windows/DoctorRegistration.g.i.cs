﻿#pragma checksum "..\..\..\Windows\DoctorRegistration.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C23DAB8B94850EC620D134CAFE9CDCA3CCA563F0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CLINIC;
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


namespace CLINIC {
    
    
    /// <summary>
    /// DoctorRegistration
    /// </summary>
    public partial class DoctorRegistration : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Windows\DoctorRegistration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox label_info;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Windows\DoctorRegistration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo_spec;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Windows\DoctorRegistration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo_doc;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\DoctorRegistration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox label_info2;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Windows\DoctorRegistration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo_time;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Windows\DoctorRegistration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Windows\DoctorRegistration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar calend;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Windows\DoctorRegistration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtomSave;
        
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
            System.Uri resourceLocater = new System.Uri("/CLINIC;component/windows/doctorregistration.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\DoctorRegistration.xaml"
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
            this.label_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.combo_spec = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\..\Windows\DoctorRegistration.xaml"
            this.combo_spec.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.combo_spec_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.combo_doc = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\..\Windows\DoctorRegistration.xaml"
            this.combo_doc.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.combo_doc_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.label_info2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.combo_time = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.text = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\Windows\DoctorRegistration.xaml"
            this.text.MouseEnter += new System.Windows.Input.MouseEventHandler(this.text_MouseMove);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\Windows\DoctorRegistration.xaml"
            this.text.MouseLeave += new System.Windows.Input.MouseEventHandler(this.text_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 7:
            this.calend = ((System.Windows.Controls.Calendar)(target));
            
            #line 43 "..\..\..\Windows\DoctorRegistration.xaml"
            this.calend.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.calend_SelectedDatesChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtomSave = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Windows\DoctorRegistration.xaml"
            this.ButtomSave.Click += new System.Windows.RoutedEventHandler(this.ButtomSave_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 47 "..\..\..\Windows\DoctorRegistration.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 48 "..\..\..\Windows\DoctorRegistration.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 49 "..\..\..\Windows\DoctorRegistration.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown_2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
