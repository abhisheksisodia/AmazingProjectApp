using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace Bootcamp2016.AmazingRace.Services
{
    public class SettingsService : ISettingsService
    {
        #region Setting Constants

        private const string RaceIdSettingKey = "race_id";
        private static readonly string RaceIdDefault = "42927fab-04db-462b-b0f9-9a8798e00dff"; // This is the InfusionPractices Race.

        private const string GcmRegIdKey = "gcm_registration";
        private static readonly string GcmRegIdDefault = string.Empty;

        #endregion

        private ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        public string RaceId
        {
            get { return AppSettings.GetValueOrDefault<string>(RaceIdSettingKey); }
            set { AppSettings.AddOrUpdateValue<string>(RaceIdSettingKey, value); }
        }

        public string GcmRegistrationId
        {
            get { return AppSettings.GetValueOrDefault<string>(GcmRegIdKey, GcmRegIdDefault); }
            set { AppSettings.AddOrUpdateValue<string>(GcmRegIdKey, value); }
        }

        public T GetValueOrDefault<T>(string key, T defaultValue = default(T))
        {
            return AppSettings.GetValueOrDefault(key, defaultValue);
        }

        public void Remove(string key)
        {
            AppSettings.Remove(key);
        }

        public bool SetValue<T>(string key, T value)
        {
            return AppSettings.AddOrUpdateValue(key, value);
        }
    }

}
