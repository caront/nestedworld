﻿#pragma checksum "E:\Git\nestedworld\NestedWorld\View\MapViews\AreaFreeView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "16B576C82137650FFA61450B3C479C45"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NestedWorld.View.MapViews
{
    partial class AreaFreeView : 
        global::Windows.UI.Xaml.Controls.UserControl, 
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
                    global::Windows.UI.Xaml.Controls.StackPanel element1 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 13 "..\..\..\..\View\MapViews\AreaFreeView.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element1).Holding += this.StackPanel_Holding;
                    #line default
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element2 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 16 "..\..\..\..\View\MapViews\AreaFreeView.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element2).Click += this.MenuFlyoutItem_Click;
                    #line default
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element3 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 17 "..\..\..\..\View\MapViews\AreaFreeView.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element3).Click += this.MenuFlyoutItem_Click_1;
                    #line default
                }
                break;
            case 4:
                {
                    this.mapControl = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                }
                break;
            case 5:
                {
                    this.DistanceTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

