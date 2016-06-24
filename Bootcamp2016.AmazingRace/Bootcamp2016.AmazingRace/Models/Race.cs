using System;
using System.Collections.Generic;

namespace Bootcamp2016.AmazingRace.Models
{
    /// <summary>
    /// Race model object
    /// </summary>
    public class Race
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public bool Enabled { get; set; }

    }
}