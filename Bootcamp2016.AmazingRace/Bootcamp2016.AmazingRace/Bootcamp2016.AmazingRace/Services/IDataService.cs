using System.Collections.Generic;
using System.Threading.Tasks;
using Bootcamp2016.AmazingRace.Models;

namespace Bootcamp2016.AmazingRace.Services
{
    /// <summary>
    /// Remote Gateway facade for communicating with server
    /// </summary>
    public interface IDataService
    {

        Task<Profile> GetProfileAsync();

        Task<Team> JoinTeamAsync(string teamCode);

        Task<IEnumerable<Race>> GetRacesAsync();

        Task<Race> GetRaceAsync(string id);

        Task<string> GetNextClueIdAsync(string teamId, string raceId);

        Task<string> SkipClueAsync(string teamId, string raceId, int skip);

        Task<Clue> GetClueAsync(string clueId);

        Task<List<Clue>> GetCluesAsync(string raceId);

        Task<bool> PostClueResponse(string clueId, double lat, double lng, byte[] dataArray);

        Task<bool> PostLocationUpdate(Location location);

        Task<string> RegisterForPushNotifications(string regId);

        Task<bool> UpdateDeviceInfoForPushNotifications(string regId, DeviceRegistration device);
    }
}
