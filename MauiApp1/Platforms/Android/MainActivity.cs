﻿using Android.App;
using Android.Content.PM;
using Android.OS;

namespace MauiApp1
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            Google.Android.Material.Internal.EdgeToEdgeUtils.ApplyEdgeToEdge(Window, true);
            if (OperatingSystem.IsAndroidVersionAtLeast((int)BuildVersionCodes.Q))
            {
                Window.StatusBarContrastEnforced = false;
                Window.NavigationBarContrastEnforced = false;
            }
             
            base.OnCreate(savedInstanceState);
        }

    }
}
