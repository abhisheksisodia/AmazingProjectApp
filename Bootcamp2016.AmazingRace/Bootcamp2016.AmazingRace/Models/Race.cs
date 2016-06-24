using System;
using System.Collections.Generic;

namespace Bootcamp2016.AmazingRace.Models
{
    /// <summary>
    /// Race model object
    /// </summary>
    public class TeamData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public int Points { get; set; }
    }

    public class Race
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public bool Enabled { get; set; }
        public List<TeamData> Teams { get; set; }
    }
}