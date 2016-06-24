using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace.Models
{
    /// <summary>
    /// Location object (used when uploading geolocation to server)
    /// </summary>
    public class Location
    {
        public string RaceId { get; set; }
        public double Longitude { get; set; }
        public double Lattitude { get; set; }
    }
}