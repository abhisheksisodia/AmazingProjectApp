

using Bootcamp2016.AmazingRace.Services;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Provides login functionality
    /// </summary>
    public class LoginViewModel : BaseScreen
    {
        private readonly IAuthenticationService _authService;
        bool authenticated = true;

        public LoginViewModel(IAuthenticationService authService)
        {
            _authService = authService;
            LoginCommand = new Command(Login);
        }
        
        public ICommand LoginCommand { get; set; }

        async void Login()
        {
            if (authenticated)
            {
                //await NavigationPage.PushAsync(new DummyViewModel());
            }

        }

    }
}
