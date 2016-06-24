using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using Bootcamp2016.AmazingRace.ViewModels;
using Xamarin.Forms;
using Bootcamp2016.AmazingRace.Services;
using Bootcamp2016.AmazingRace.Views;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace
{
    public class App : FormsApplication
    {
        //DEV
        private static string MobileServicesUri = "https://infusionamazingrace.azure-mobile.net/";
        private static string MobileServicesAppKey = "XlYlBNtwuFzFROAbFpblbBQEPmdPJg64";

        ////PROD
        //public static string MobileServicesUri = "https://infusionamazingrace.azure-mobile.net/";
        //public static string MobileServicesAppKey = "XlYlBNtwuFzFROAbFpblbBQEPmdPJg64";

        private readonly SimpleContainer container;

        public App(SimpleContainer container)
        {
            this.container = container;

            container
                .PerRequest<LoginViewModel>()
                .PerRequest<LeaderViewModel>()
                .PerRequest<CluesViewModel>()
                .PerRequest<DetailViewModel>()
                .PerRequest<TabbedViewModel>()
                .PerRequest<MapViewModel>()
                .Singleton<ISettingsService, SettingsService>()
                .Singleton<IAuthenticationService,AuthenticationService>()
                .Singleton<IDataService, DataService>()
                .Instance<IMobileServiceClient>(new MobileServiceClient(MobileServicesUri, MobileServicesAppKey))
                ;

            DisplayRootView<LoginView>();
        }

        protected override void PrepareViewFirst(NavigationPage navigationPage)
        {
            container.Instance<INavigationService>(new NavigationPageAdapter(navigationPage));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
