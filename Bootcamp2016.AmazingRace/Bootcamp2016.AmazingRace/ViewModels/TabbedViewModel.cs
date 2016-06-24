

using Bootcamp2016.AmazingRace.TemplateSelectors;
using Caliburn.Micro;
using Xamarin.Forms;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Tabbed view to contain a leader list and a clues list
    /// </summary>
    public class TabbedViewModel : Conductor<BaseScreen>.Collection.OneActive
    {
        private readonly CluesViewModel _cluesViewModel;
        private readonly LeaderViewModel _leaderViewModel;
        public TabbedViewModel(CluesViewModel cluesViewModel, LeaderViewModel leaderViewModel)
        {
            _cluesViewModel = cluesViewModel;
            _leaderViewModel = leaderViewModel;
            TemplateSelector = new CaliburnTemplateSelector();
            Items.Add(cluesViewModel);
            Items.Add(leaderViewModel);
        }

        protected override void OnActivate()
        {
            base.OnActivate();
            _cluesViewModel.RefreshClues();
            _leaderViewModel.RefreshTeams();
        }

        public DataTemplateSelector TemplateSelector { get; set; }
    }
}
