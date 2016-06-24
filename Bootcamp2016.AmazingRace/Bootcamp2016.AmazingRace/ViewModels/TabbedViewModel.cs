

using Bootcamp2016.AmazingRace.TemplateSelectors;
using Caliburn.Micro;
<<<<<<< HEAD
using System;
using System.Runtime.CompilerServices;
=======
>>>>>>> 8ae78eae039a3feeaf773d00c36b1ae7bd4a9bb8
using Xamarin.Forms;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Tabbed view to contain a leader list and a clues list
    /// </summary>
    public class TabbedViewModel : Conductor<BaseScreen>.Collection.OneActive
    {
        public TabbedViewModel(CluesViewModel cluesViewModel, LeaderViewModel leaderViewModel)
        {
            TemplateSelector = new CaliburnTemplateSelector();
            Items.Add(cluesViewModel);
            Items.Add(leaderViewModel);
        }

        public DataTemplateSelector TemplateSelector { get; set; }
    }
}
