using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace.Services
{
    /// <summary>
    /// Provides a simple wrapper around Authentication components
    /// </summary>
    public interface IAuthenticationService
    {

        Task<bool> IsLoggedInAsync();

        Task<bool> LoginAsync();

        Task LogoutAsync();

    }
}
