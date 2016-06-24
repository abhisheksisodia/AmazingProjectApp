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

namespace Bootcamp2016.AmazingRace.Droid
{
    public class PlatformAuthenticator : IPlatformAuthenticator
    {
        public Task<MobileServiceUser> Authenticate(MobileServiceAuthenticationProvider provider)
        {
            MobileServiceUser user = null;
            try
            {
                // Sign in with Facebook login using a server-managed flow.
                //user = new MobileServiceUser()
            }
            catch (Exception ex)
            {
                //CreateAndShowDialog(ex.Message, "Authentication failed");
            }
            throw new NotImplementedException();
            //return user;
        }
    }
}