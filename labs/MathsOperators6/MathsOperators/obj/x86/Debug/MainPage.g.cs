﻿#pragma checksum "C:\Users\nguye\quantico06\playpen\MathsOperators\MathsOperators\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B01D6C02144C028CADE08CA5D878836C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MathsOperators
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
            case 2: // MainPage.xaml line 30
                {
                    this.lhs = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // MainPage.xaml line 31
                {
                    this.rhs = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // MainPage.xaml line 32
                {
                    this.lhsOperand = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // MainPage.xaml line 33
                {
                    this.rhsOperand = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // MainPage.xaml line 34
                {
                    this.operators = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7: // MainPage.xaml line 41
                {
                    this.calculate = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.calculate).Click += this.calculateClick;
                }
                break;
            case 8: // MainPage.xaml line 43
                {
                    this.expression = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // MainPage.xaml line 45
                {
                    this.result = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // MainPage.xaml line 35
                {
                    this.addition = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 11: // MainPage.xaml line 36
                {
                    this.subtraction = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 12: // MainPage.xaml line 37
                {
                    this.multiplication = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 13: // MainPage.xaml line 38
                {
                    this.division = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 14: // MainPage.xaml line 39
                {
                    this.remainder = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
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

