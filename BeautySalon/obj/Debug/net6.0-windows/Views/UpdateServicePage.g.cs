﻿#pragma checksum "..\..\..\..\Views\UpdateServicePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D15493C6DC458B6A701C6D900E01C90C61660677"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BeautySalon.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace BeautySalon.Views {
    
    
    /// <summary>
    /// UpdateServicePage
    /// </summary>
    public partial class UpdateServicePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Views\UpdateServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label headerLabel;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Views\UpdateServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox callservice;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Views\UpdateServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox costservice;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BeautySalon;component/views/updateservicepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\UpdateServicePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.headerLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            
            #line 24 "..\..\..\..\Views\UpdateServicePage.xaml"
            ((System.Windows.Controls.Image)(target)).Loaded += new System.Windows.RoutedEventHandler(this.updateImage);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 45 "..\..\..\..\Views\UpdateServicePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addServicePhoto);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 49 "..\..\..\..\Views\UpdateServicePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.deletedop);
            
            #line default
            #line hidden
            return;
            case 5:
            this.callservice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.costservice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 93 "..\..\..\..\Views\UpdateServicePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.saveChanges);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 94 "..\..\..\..\Views\UpdateServicePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goBack);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

