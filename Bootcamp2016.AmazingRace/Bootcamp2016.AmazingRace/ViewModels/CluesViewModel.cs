

using Bootcamp2016.AmazingRace.Models;
using Bootcamp2016.AmazingRace.Services;
using Caliburn.Micro.Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Provides a list of current clues for a specific race
    /// </summary>
    public class CluesViewModel : BaseScreen
    {
        private readonly IDataService _dataService;
        private readonly ISettingsService _settingsService;
        private readonly INavigationService _navService;

        private Clue _selectedClue;

        public CluesViewModel(INavigationService navService,
                              IDataService dataService,
                              ISettingsService settingsService)
        {
            _navService = navService;
            _dataService = dataService;
            _settingsService = settingsService;
            Clues = new ObservableCollection<Clue>();
            RefreshCommand = new Command(RefreshClues);
        }

        public async void RefreshClues()
        {
            Clues.Clear();
            var clues = await _dataService.GetCluesAsync(_settingsService.RaceId);
            foreach (var clue in clues)
            {
                Clues.Add(clue);
            }
        }

        public ICommand RefreshCommand { get; set; }
        public ObservableCollection<Clue> Clues { get; set; }

        public Clue SelectedClue
        {
            get { return _selectedClue; }
            set
            {
                _selectedClue = value;
                _navService.NavigateToViewModelAsync<DetailViewModel>(value);
            }
        }
    }
}
