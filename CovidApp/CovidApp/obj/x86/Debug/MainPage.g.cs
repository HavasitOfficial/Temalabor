﻿#pragma checksum "D:\Users\Acer\Documents\Témalabor\CovidApp\CovidApp\CovidApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "183A1365671194A816329F2C4C27A3D4"
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
    partial class MainPage : 
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
            case 2: // MainPage.xaml line 11
                {
                    this.MainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // MainPage.xaml line 14
                {
                    this.MenuSplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 4: // MainPage.xaml line 15
                {
                    this.popUp = (global::Windows.UI.Xaml.Controls.Primitives.Popup)(target);
                }
                break;
            case 5: // MainPage.xaml line 17
                {
                    this.Username = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // MainPage.xaml line 18
                {
                    this.Password = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // MainPage.xaml line 19
                {
                    this.Enter = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Enter).Click += this.Enter_Click;
                }
                break;
            case 8: // MainPage.xaml line 23
                {
                    this.MainPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 9: // MainPage.xaml line 35
                {
                    this.infected = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.infected).Click += this.infected_Click;
                }
                break;
            case 10: // MainPage.xaml line 32
                {
                    this.Statics = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Statics).Click += this.Statics_Click;
                }
                break;
            case 11: // MainPage.xaml line 29
                {
                    this.register = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.register).Click += this.register_Click;
                }
                break;
            case 12: // MainPage.xaml line 26
                {
                    this.SignIn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SignIn).Click += this.SignIn_Click;
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

