namespace Bootcamp2016.AmazingRace.Models
{
    /// <summary>
    /// Team model object
    /// </summary>
    public class Team
    {
        public string TeamId { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public int Points{ get; set; }
        public string NextClueId { get; set; }
    }
}