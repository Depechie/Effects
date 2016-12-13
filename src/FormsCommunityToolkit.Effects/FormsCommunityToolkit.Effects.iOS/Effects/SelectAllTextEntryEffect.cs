﻿using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using FormsCommunityToolkit.Effects.iOS.Effects;
using UIKit;
using Foundation;
using ObjCRuntime;

[assembly: ExportEffect(typeof(SelectAllTextEntryEffect), nameof(SelectAllTextEntryEffect))]

namespace FormsCommunityToolkit.Effects.iOS.Effects
{
    [Preserve(AllMembers = true)]
	public class SelectAllTextEntryEffect : PlatformEffect
	{
        private UITextAutocapitalizationType _old;

		protected override void OnAttached()
		{
            var editText = Control as UITextField;
			if (editText != null)
			{
				editText.EditingDidBegin += (object sender, System.EventArgs e) =>
				{
					editText.PerformSelector(new Selector("selectAll"), null, 0.0f);
				};
			}
		}

		protected override void OnDetached()
		{
			var editText = Control as UITextField;
			if (editText != null) {
				editText.EditingDidBegin -= (object sender, System.EventArgs e) =>
				{
					editText.PerformSelector(new Selector("selectAll"), null, 0.0f);
				};
			}
		}
	}
}
