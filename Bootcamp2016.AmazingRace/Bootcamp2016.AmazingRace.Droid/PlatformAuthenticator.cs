using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Bootcamp2016.AmazingRace.Services;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;

namespace Bootcamp2016.AmazingRace.Droid
{
    public class PlatformAuthenticator : IPlatformAuthenticator
    {
        private readonly IMobileServiceClient _client;
        public PlatformAuthenticator(IMobileServiceClient client)
        {
            _client = client;
        }

        public async Task<MobileServiceUser> Authenticate(MobileServiceAuthenticationProvider provider)
        {
            MobileServiceUser user = null;
            try
            {
                // Sign in with Facebook login using a server-managed flow.
                user = await _client.LoginAsync(Forms.Context, provider);
            }
            catch (Exception ex)
            {
                //TODO: log
            }
            return user;
            //return user;
        }
    }
}