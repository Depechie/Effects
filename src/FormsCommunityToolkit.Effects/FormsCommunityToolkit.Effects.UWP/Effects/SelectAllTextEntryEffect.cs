﻿using Windows.UI.Xaml.Controls;
using FormsCommunityToolkit.Effects.UWP.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportEffect(typeof(SelectAllTextEntryEffect), nameof(SelectAllTextEntryEffect))]

namespace FormsCommunityToolkit.Effects.UWP.Effects
{
    [Preserve]
    public class CapitalizeKeyboardEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var textbox = Control as TextBox;
            if (textbox != null)
            {
                textbox.TextChanging -= TextboxOnTextChanging;
                textbox.TextChanging += TextboxOnTextChanging;
            }
        }

        private static void TextboxOnTextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            var selectionStart = sender.SelectionStart;
            sender.Text = sender.Text.ToUpper();
            sender.SelectionStart = selectionStart;
            sender.SelectionLength = 0;
        }

        protected override void OnDetached()
        {
            var textbox = Control as TextBox;
            if (textbox != null)
            {
                textbox.TextChanging -= TextboxOnTextChanging;
            }
        }
    }
}
