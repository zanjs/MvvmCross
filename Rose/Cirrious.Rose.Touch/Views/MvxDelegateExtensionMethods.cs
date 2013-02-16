﻿using System;
using System.Collections.Generic;
using Cirrious.MvvmCross.Droid.Views;

namespace Cirrious.CrossCore.Touch.Views
{
    public static class MvxDelegateExtensionMethods
    {
        public static void Raise(this EventHandler eventHandler, object sender)
        {
            if (eventHandler == null)
                return;

            eventHandler(sender, EventArgs.Empty);
        }

        public static void Raise<T>(this EventHandler<TypedEventArgs<T>> eventHandler, object sender, T value)
        {
            if (eventHandler == null)
                return;

            eventHandler(sender, new TypedEventArgs<T>(value));
        }
    }
}