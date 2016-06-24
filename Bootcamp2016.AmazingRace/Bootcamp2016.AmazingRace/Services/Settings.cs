// Helpers/Settings.cs
using System;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using Caliburn.Micro;

namespace Bootcamp2016.AmazingRace.Services
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class Settings
    {
        public static ISettingsService Current { get { return IoC.Get<ISettingsService>(); } }
    }
}