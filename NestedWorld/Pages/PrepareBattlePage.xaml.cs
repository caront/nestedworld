﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace NestedWorld.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PrepareBattlePage : Page
    {
        public PrepareBattlePage()
        {
            this.InitializeComponent();
            userMonsterListView.monsterList = App.core.monsterUserList;
            profileEntrance.User = App.core.user;
            profileEntrance.Enemie = App.core.userList.userList[1];
            profileEntrance.Begin();
            Show.Begin();
        }

        private void OK_click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pages.BattlePage), userMonsterListView.SelectedMonsterList);
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {

        }

        private void Reset_click(object sender, RoutedEventArgs e)
        {

        }
      
    }
}
