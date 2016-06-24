namespace Bootcamp2016.AmazingRace.Models
{
    /// <summary>
    /// Clue details
    /// </summary>
    public class Clue
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Range { get; set; }
    }
}