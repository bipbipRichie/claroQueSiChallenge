﻿#pragma checksum "C:\Users\BBRMX\source\repos\ClaroQueSi\ClaroQueSi\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A7B82174B1FAD2A50073C543CD55CAF9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClaroQueSi
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 55
                {
                    this.gridMovies = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)this.gridMovies).ItemClick += this.GridMovies_ItemClick;
                }
                break;
            case 4: // MainPage.xaml line 45
                {
                    this.btnStart = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 5: // MainPage.xaml line 46
                {
                    this.btnCatalog = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 6: // MainPage.xaml line 47
                {
                    this.btnGenre = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 7: // MainPage.xaml line 48
                {
                    this.btnBuyRent = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 8: // MainPage.xaml line 49
                {
                    this.btnChannels = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 9: // MainPage.xaml line 50
                {
                    this.btnKids = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

