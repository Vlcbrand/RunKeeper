﻿#pragma checksum "C:\Users\Tom Remeeus\Documents\GitHub\RunKeeper\Runkeeper\Runkeeper\View\RunningPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "484CA954F1B104A3EAFB6BFECF748704"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Runkeeper
{
    partial class RunningPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Afstand = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2:
                {
                    this.SpeedText = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    this.TimeBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.speedblock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.afstandtext = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.START = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 35 "..\..\..\View\RunningPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.START).Click += this.START_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.Stop = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\View\RunningPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Stop).Click += this.Stop_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
