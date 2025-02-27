﻿using NestedWorld.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace NestedWorld.Classes.Chat
{
    public class MessageContentPresenter : ContentControl
    {
        public DataTemplate LeftTemplate { get; set; }
        public DataTemplate RightTemplate { get; set; }

        protected override void OnContentChanged(object oldContent, object newContent)
        {
            base.OnContentChanged(oldContent, newContent);
            Message message = newContent as Message;
            if (message.who == eWho.ME)
                ContentTemplate = RightTemplate;
            else
                ContentTemplate = LeftTemplate;
        }

    }
}
