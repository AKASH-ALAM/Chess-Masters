﻿#pragma checksum "..\..\..\PromotionMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B564964F1D349EF02B06564F711CDBE780F1BEEB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ChessUI;
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


namespace ChessUI {
    
    
    /// <summary>
    /// PromotionMenu
    /// </summary>
    public partial class PromotionMenu : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\PromotionMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image QueenImg;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\PromotionMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image BishopImg;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\PromotionMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image RookImg;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\PromotionMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image KnightImg;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ChessUI;component/promotionmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PromotionMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.QueenImg = ((System.Windows.Controls.Image)(target));
            
            #line 25 "..\..\..\PromotionMenu.xaml"
            this.QueenImg.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.QueenImg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BishopImg = ((System.Windows.Controls.Image)(target));
            
            #line 28 "..\..\..\PromotionMenu.xaml"
            this.BishopImg.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.BishopImg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RookImg = ((System.Windows.Controls.Image)(target));
            
            #line 31 "..\..\..\PromotionMenu.xaml"
            this.RookImg.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.RookImg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.KnightImg = ((System.Windows.Controls.Image)(target));
            
            #line 34 "..\..\..\PromotionMenu.xaml"
            this.KnightImg.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.KnightImg_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

