﻿#pragma checksum "C:\Users\berdin.TXTMI00\Documents\Visual Studio 2010\Projects\JP\JPManager\Jalkapallo Solution\JPManager\Jalkapallo_UI\DrawableObj\MatchListEntry.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "46B72B7C222D9827C741FC71E0019A84"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Jalkapallo_UI.DrawableObj {
    
    
    public partial class MatchListEntry : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid SuperiorGrid;
        
        internal System.Windows.Controls.Grid ContextGrid;
        
        internal System.Windows.Controls.TextBlock Squadre;
        
        internal System.Windows.Controls.TextBlock Risultato;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Jalkapallo_UI;component/DrawableObj/MatchListEntry.xaml", System.UriKind.Relative));
            this.SuperiorGrid = ((System.Windows.Controls.Grid)(this.FindName("SuperiorGrid")));
            this.ContextGrid = ((System.Windows.Controls.Grid)(this.FindName("ContextGrid")));
            this.Squadre = ((System.Windows.Controls.TextBlock)(this.FindName("Squadre")));
            this.Risultato = ((System.Windows.Controls.TextBlock)(this.FindName("Risultato")));
        }
    }
}

