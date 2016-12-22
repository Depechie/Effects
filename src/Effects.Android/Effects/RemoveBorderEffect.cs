﻿using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using FormsCommunityToolkit.Effects.Droid.Effects;
using Android.Runtime;

[assembly: ExportEffect(typeof(RemoveBorderEffect), nameof(RemoveBorderEffect))]

namespace FormsCommunityToolkit.Effects.Droid.Effects
{
    [Preserve(AllMembers = true)]
    public class RemoveBorderEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
        }

        protected override void OnDetached()
        {
        }
    }
}