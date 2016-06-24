

using Bootcamp2016.AmazingRace.Models;
using Bootcamp2016.AmazingRace.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Provides a list of leaders in order for a specific race
    /// </summary>
    public class LeaderViewModel : BaseScreen
    {
        private readonly IDataService _dataService;
        private readonly ISettingsService _settingsService;
        private bool _isRefreshing;
        public LeaderViewModel(IDataService dataService,
                               ISettingsService settingsService)
        {
            _dataService = dataService;
            _settingsService = settingsService;
            Teams = new ObservableCollection<TeamData>();
            RefreshCommand = new Command(RefreshTeams);
        }

        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set { SetField(ref _isRefreshing, value); }
        }

        public async void RefreshTeams()
        {
            IsRefreshing = true;
            Teams.Clear();
            Race race = await _dataService.GetRaceAsync(_settingsService.RaceId);
            foreach (var team in race.Teams.OrderBy(t => t.Rank))
            {
                Teams.Add(team);
            }
            IsRefreshing = false;
        }

        public ICommand RefreshCommand { get; set; }
        public ObservableCollection<TeamData> Teams { get; set; }

    }
}
