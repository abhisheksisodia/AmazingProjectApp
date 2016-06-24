using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace.Models
{
    /// <summary>
    /// Represents payload information when submitting a clue response to the server
    /// </summary>
    public class PostClueRequest
    {
        public string ClueId { get; set; }
        public byte[] Data { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
