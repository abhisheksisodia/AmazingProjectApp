

using Bootcamp2016.AmazingRace.Models;
using System.Collections.ObjectModel;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Provides a list of leaders in order for a specific race
    /// </summary>
    public class LeaderViewModel : BaseScreen
    {
        public ObservableCollection<Team> Teams { get; set; }
        public LeaderViewModel()
        {
            Teams = new ObservableCollection<Team>();
        }

        // get race ID
        // populate listView with ImageCells

        // on pull-to-refresh, make a GET request for teams
        public void refreshLeaders()
        {

        }

        // listView.IsPullToRefreshEnabled = true;
        
        // ListView exposes a few events that allow you to respond to pull-to-refresh events.
        //      The RefreshCommand will be invoked and the Refreshing event called.IsRefreshing will be set to true.
        //      You should perform whatever code is required to refresh the contents of the list view, either in the command or event.
        //      When refreshing is complete, call EndRefresh or set IsRefreshing to false to tell the list view that you're done.

    }
}
