using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace.Services
{
    /// <summary>
    /// A simple mechanism to display alerts
    /// </summary>
    public interface IMessageDialogService
    {
        Task ShowAsync(string title, string message);
    }
}
