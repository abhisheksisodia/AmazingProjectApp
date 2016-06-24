

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
        public TabbedViewModel()
        {
            TemplateSelector = new CaliburnTemplateSelector();
        }
        public DataTemplateSelector TemplateSelector { get; set; }
    }
}
