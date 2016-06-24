using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace.Services
{
    /// <summary>
    /// Abstraction for platform-specific authentication
    /// </summary>
    public interface IPlatformAuthenticator
    {
        Task<MobileServiceUser> Authenticate(MobileServiceAuthenticationProvider provider);
    }
}
