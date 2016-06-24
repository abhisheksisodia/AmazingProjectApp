using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bootcamp2016.AmazingRace.Models;
using Microsoft.WindowsAzure.MobileServices;
using System.Net.Http;

namespace Bootcamp2016.AmazingRace.Services
{
    public class DataService : IDataService
    {
        private readonly IMobileServiceClient _mobileClient;
        public DataService(IMobileServiceClient mobileClient)
        {
            _mobileClient = mobileClient;
        }
        public async Task<Clue> GetClueAsync(string clueId)
        {
            string url = string.Format("clue/{0}", clueId);
            return await _mobileClient.InvokeApiAsync<Clue>(url, HttpMethod.Get, null);
        }

        public async Task<List<Clue>> GetCluesAsync(string raceId)
        {
            string url = string.Format("race/{0}/clues", raceId);
            return await _mobileClient.InvokeApiAsync<List<Clue>>(url, HttpMethod.Get, null);
        }

        public async Task<string> GetNextClueIdAsync(string teamId, string raceId)
        {
            string url = string.Format("race/{0}/team/{1}", teamId, raceId);
            return await _mobileClient.InvokeApiAsync<string>(url, HttpMethod.Get, null);
        }

        public async Task<Profile> GetProfileAsync()
        {
            return await _mobileClient.InvokeApiAsync<Profile>("profile", HttpMethod.Get, null);
        }

        public async Task<Race> GetRaceAsync(string id)
        {
            string url = string.Format("race/{0}", id);
            return await _mobileClient.InvokeApiAsync<Race>(url, HttpMethod.Get, null);
        }

        public async Task<IEnumerable<Race>> GetRacesAsync()
        {
            return await _mobileClient.InvokeApiAsync<List<Race>>("race", HttpMethod.Get, null);
        }

        public async Task<Team> JoinTeamAsync(string teamCode)
        {
            var queryDict = new Dictionary<string, string>() { { "joinCode", teamCode } };
            return await _mobileClient.InvokeApiAsync<Team>("profile", HttpMethod.Post, queryDict);
        }

        public async Task<bool> PostClueResponse(string clueId, double lat, double lng, byte[] dataArray)
        {
            var requestBody = new PostClueRequest()
            {
                ClueId = clueId,
                Latitude = lat,
                Longitude = lng,
                Data = dataArray
            };
            try
            {
                await _mobileClient.InvokeApiAsync<PostClueRequest, PostClueResponse>("clue", requestBody, HttpMethod.Post, null);
                return true;
            } catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> PostLocationUpdate(Location location)
        {
            try
            {
                await _mobileClient.InvokeApiAsync<Location>("updatelocation", HttpMethod.Post, null);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<string> RegisterForPushNotifications(string regId)
        {
            throw new NotImplementedException();
        }

        public async Task<string> SkipClueAsync(string teamId, string raceId, int skip)
        {
            var queryDict = new Dictionary<string, string>() { { "skip", skip.ToString() } };
            string url = string.Format("race/{0}/team/{1}", teamId, raceId);
            return await _mobileClient.InvokeApiAsync<string>(url, HttpMethod.Get, queryDict);
        }

        public async Task<bool> UpdateDeviceInfoForPushNotifications(string regId, DeviceRegistration device)
        {
            throw new NotImplementedException();
        }
    }
}
