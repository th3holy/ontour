﻿#pragma checksum "..\..\ventas.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80DB628C2C5287EDF71A8FD0BBFF7D6EECB84B3D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using vistas;


namespace vistas {
    
    
    /// <summary>
    /// ventas
    /// </summary>
    public partial class ventas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_NombreCliente;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_ApellidoCliente;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Email;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_NROPersonas;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Precio;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_total;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Contrato;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button limpiar;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ventas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tabla;
        
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
            System.Uri resourceLocater = new System.Uri("/vistas;component/ventas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ventas.xaml"
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
            this.txt_NombreCliente = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txt_ApellidoCliente = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_Email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_NROPersonas = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_Precio = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txt_total = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 23 "..\..\ventas.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Contrato = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.limpiar = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\ventas.xaml"
            this.limpiar.Click += new System.Windows.RoutedEventHandler(this.limpiar_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.tabla = ((System.Windows.Controls.DataGrid)(target));
            
            #line 26 "..\..\ventas.xaml"
            this.tabla.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.tabla_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

