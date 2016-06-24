using Microsoft.WindowsAzure.MobileServices;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Auth;

namespace Bootcamp2016.AmazingRace.Services
{
    /// <summary>
    /// Implementation of Authentication Service
    /// </summary>
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IPlatformAuthenticator _authenticator;
        private readonly IMobileServiceClient _mobileService;
        private readonly IDataService _dataService;
        private readonly AccountStore _accountStore;
        

        private const MobileServiceAuthenticationProvider Provider = MobileServiceAuthenticationProvider.Google;
        private static string AuthProvider => Provider.ToString();

        public AuthenticationService(IPlatformAuthenticator authenticator, IMobileServiceClient mobileService, IDataService dataService)
        {
            _authenticator = authenticator;
            _mobileService = mobileService;
            _dataService = dataService;

            _accountStore = AccountStore.Create();
        }

        public async Task<bool> IsLoggedInAsync()
        {
            var accounts = await _accountStore.FindAccountsForServiceAsync(AuthProvider);

            Account account = accounts.FirstOrDefault();

            if (account == null) return false;

            MobileServiceUser user = new MobileServiceUser(account.Username)
            {
                MobileServiceAuthenticationToken = account.Properties["Password"]
            };

            _mobileService.CurrentUser = user;

            return true;
        }

        public async Task<bool> LoginAsync()
        {
            var user = await _authenticator.Authenticate(Provider);

            if (user == null)
            {
                return false;
            }

            _mobileService.CurrentUser = user;

            var account = new Account(user.UserId);

            account.Properties["Password"] = user.MobileServiceAuthenticationToken;

            await _accountStore.SaveAsync(account, AuthProvider);

            await _dataService.GetProfileAsync();

            return true;
        }

        public async Task LogoutAsync()
        {
            var accounts = await _accountStore.FindAccountsForServiceAsync(AuthProvider);

            foreach (var account in accounts)
            {
                await _accountStore.DeleteAsync(account, AuthProvider);
            }
        }

    }
}
