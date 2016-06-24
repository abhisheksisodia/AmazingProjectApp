using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace.Models
{
    /// <summary>
    /// Represents the response information received from the server when submitting a clue response
    /// </summary>
    public class PostClueResponse
    {
        public string Id { get; set; }
        public string ClueId { get; set; }
        public string RaceId { get; set; }
        public string TeamId { get; set; }
        public string UserId { get; set; }

        public string Data { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string ImageUri { get; set; }
        public string ContainerName { get; set; }
        public string ResourceName { get; set; }
        public string SasQueryString { get; set; }
    }
}
