﻿

using Bootcamp2016.AmazingRace.Services;
using Caliburn.Micro.Xamarin.Forms;
using System;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly IDataService _dataService;
        private readonly ISettingsService _settingsService;
        private bool _isAuthenticated;
        private string _teamName;

        public LoginViewModel(IAuthenticationService authService, INavigationService navService,
                              IDataService dataService, ISettingsService settingsService)
        {
            _settingsService = settingsService;
            _navService = navService;
            _authService = authService;
            _dataService = dataService;
            LoginCommand = new Command(Login);
            JoinCommand = new Command(Join);
        }
        
        public ICommand LoginCommand { get; set; }
        public ICommand JoinCommand { get; set; }
        
        public bool IsAuthenticated
        {
            get { return _isAuthenticated; }
            set { SetField(ref _isAuthenticated, value); }
        }

        public string TeamName
        {
            get { return _teamName; }
            set { SetField(ref _teamName, value); }
        }

        //called to authenticate user
        async void Login()
        {
            IsAuthenticated = await _authService.LoginAsync();
        }

        private async void Join()
        {
            if (string.IsNullOrEmpty(TeamName))
                return;
            await _dataService.JoinTeamAsync(TeamName);

            var races = await _dataService.GetRacesAsync();
            if (races.Any())
                _settingsService.RaceId = races.First().Id;

            await _navService.NavigateToViewModelAsync<TabbedViewModel>();
        }


        protected async override void OnInitialize()
        {
            base.OnInitialize();
            IsAuthenticated = await _authService.IsLoggedInAsync();
        }       

    }
}
