﻿#pragma checksum "..\..\mainPlayer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "65BB3C8D1BD56C11E163437145D4069101721C0287CD9E1DBFEF447EC6566A0E"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

using Grante;
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


namespace Grante {
    
    
    /// <summary>
    /// mainPlayer
    /// </summary>
    public partial class mainPlayer : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\mainPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Grante.mainPlayer playerPage;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\mainPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas mainCanvas;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\mainPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas uprCanvas;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\mainPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas msgCanvas;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\mainPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel _mW;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\mainPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock chara_Tex;
        
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
            System.Uri resourceLocater = new System.Uri("/Grante;component/mainplayer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\mainPlayer.xaml"
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
            this.playerPage = ((Grante.mainPlayer)(target));
            
            #line 9 "..\..\mainPlayer.xaml"
            this.playerPage.Loaded += new System.Windows.RoutedEventHandler(this.playerPage_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mainCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.uprCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 13 "..\..\mainPlayer.xaml"
            this.uprCanvas.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.uprCanvas_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.msgCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 14 "..\..\mainPlayer.xaml"
            this.msgCanvas.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.msgCanvas_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this._mW = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 6:
            this.chara_Tex = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

