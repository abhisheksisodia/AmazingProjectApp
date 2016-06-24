

using Bootcamp2016.AmazingRace.Models;
using Bootcamp2016.AmazingRace.Services;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Provides the details for a specific clue
    /// </summary>
    public class DetailViewModel : BaseScreen
    {
        public Clue Clue { get; set; }
        public string Description { get { return Clue.Description; } }
        public string Points { get { return Clue.Points; } }
        public double Latitude { get { return Clue.Latitude; } }
        public double Longitude { get { return Clue.Longitude; } }

    }
}
