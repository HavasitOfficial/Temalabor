﻿#pragma checksum "D:\Users\Acer\Documents\Témalabor\CovidApp\CovidApp\CovidApp\ListInfected.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6296AB34F93050981A3EEAC8A039D000"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CovidApp
{
    partial class ListInfected : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // ListInfected.xaml line 11
                {
                    this.myGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // ListInfected.xaml line 20
                {
                    this.Sorszám = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // ListInfected.xaml line 21
                {
                    this.Kor = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // ListInfected.xaml line 22
                {
                    this.Tunetek = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // ListInfected.xaml line 23
                {
                    this.Megye = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // ListInfected.xaml line 24
                {
                    this.Refresh = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Refresh).Click += this.Refresh_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
