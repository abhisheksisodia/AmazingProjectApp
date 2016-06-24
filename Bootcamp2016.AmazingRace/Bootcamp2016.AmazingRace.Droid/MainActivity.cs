using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using Bootcamp2016.AmazingRace.Services;
using Caliburn.Micro;
using Xamarin.Forms.Platform.Android;

namespace Bootcamp2016.AmazingRace.Droid
{
    [Activity(Label = "Bootcamp2016.AmazingRace", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            Xamarin.FormsMaps.Init(this, bundle);
            LoadApplication(new App(IoC.Get<SimpleContainer>()));
        }

    }
}