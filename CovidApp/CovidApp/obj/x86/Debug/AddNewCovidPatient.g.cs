﻿#pragma checksum "D:\Users\Acer\Documents\Témalabor\CovidApp\CovidApp\CovidApp\AddNewCovidPatient.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "311D2E81EF217D7E8281436EE82518FA"
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
    partial class AddNewCovidPatient : 
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
            case 2: // AddNewCovidPatient.xaml line 40
                {
                    this.registerPatient = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 3: // AddNewCovidPatient.xaml line 14
                {
                    this.patientName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // AddNewCovidPatient.xaml line 16
                {
                    this.patientRegion = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // AddNewCovidPatient.xaml line 18
                {
                    this.sexCheck = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6: // AddNewCovidPatient.xaml line 30
                {
                    this.patientEmailAddress = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // AddNewCovidPatient.xaml line 34
                {
                    this.symptom1 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 8: // AddNewCovidPatient.xaml line 35
                {
                    this.symptom2 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 9: // AddNewCovidPatient.xaml line 36
                {
                    this.symptom3 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 10: // AddNewCovidPatient.xaml line 26
                {
                    this.patientAge = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // AddNewCovidPatient.xaml line 19
                {
                    this.male = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 12: // AddNewCovidPatient.xaml line 20
                {
                    this.famale = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
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
