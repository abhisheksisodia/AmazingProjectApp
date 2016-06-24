using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace.Services
{
    /// <summary>
    /// An abstraction to decouple services from underlying setting storage mechanisms
    /// </summary>
    public interface ISettingsService
    {
        T GetValueOrDefault<T>(string key, T defaultValue = default(T));

        bool SetValue<T>(string key, T value);

        void Remove(string key);

        string RaceId { get; set; }

        string GcmRegistrationId { get; set; }
    }
}
