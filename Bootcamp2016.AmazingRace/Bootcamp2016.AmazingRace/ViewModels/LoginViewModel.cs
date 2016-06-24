

using Bootcamp2016.AmazingRace.Services;
using Caliburn.Micro.Xamarin.Forms;
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
        private readonly INavigationService _navService;
        private readonly IAuthenticationService _authService;
        private bool _isAuthenticated;

        public LoginViewModel(IAuthenticationService authService, INavigationService navService)
        {
            _navService = navService;
            _authService = authService;
            LoginCommand = new Command(Login);
        }
        
        public ICommand LoginCommand { get; set; }

        public bool IsAuthenticated
        {
            get { return _isAuthenticated; }
            set { SetField(ref _isAuthenticated, value); }
        }

        async void Login()
        {
            IsAuthenticated = await _authService.LoginAsync();
            if (IsAuthenticated)
                await _navService.NavigateToViewModelAsync<TabbedViewModel>();
        }

    }
}
