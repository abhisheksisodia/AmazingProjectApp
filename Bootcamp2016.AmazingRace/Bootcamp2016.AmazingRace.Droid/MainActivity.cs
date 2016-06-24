using System;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using Bootcamp2016.AmazingRace.Services;
using Caliburn.Micro;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms.Platform.Android;

namespace Bootcamp2016.AmazingRace.Droid
{
    [Activity(Label = "Bootcamp2016.AmazingRace", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            Xamarin.FormsMaps.Init(this, bundle);

            //IPlatformAuthenticator

            var container = IoC.Get<SimpleContainer>();
            container.Singleton<IPlatformAuthenticator,PlatformAuthenticator>();
            LoadApplication(new App(container));
        }
    }
}