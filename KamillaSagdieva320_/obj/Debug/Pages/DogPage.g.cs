﻿#pragma checksum "..\..\..\Pages\DogPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D2A2FEDF070A58273B18A2EF60E48560A1BB3262B978E1CBCAF65A966B16B199"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using KamillaSagdieva320_.Pages;
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


namespace KamillaSagdieva320_.Pages {
    
    
    /// <summary>
    /// DogPage
    /// </summary>
    public partial class DogPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\Pages\DogPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView AnimalsLV;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Pages\DogPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPhotoBTN;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Pages\DogPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image TestImage;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Pages\DogPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ActionFilterCB;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Pages\DogPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTB;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\Pages\DogPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBTN;
        
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
            System.Uri resourceLocater = new System.Uri("/KamillaSagdieva320_;component/pages/dogpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\DogPage.xaml"
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
            this.AnimalsLV = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.AddPhotoBTN = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\Pages\DogPage.xaml"
            this.AddPhotoBTN.Click += new System.Windows.RoutedEventHandler(this.AddPhotoBTN_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TestImage = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.ActionFilterCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.SearchTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 123 "..\..\..\Pages\DogPage.xaml"
            this.SearchTB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTB_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AddBTN = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

