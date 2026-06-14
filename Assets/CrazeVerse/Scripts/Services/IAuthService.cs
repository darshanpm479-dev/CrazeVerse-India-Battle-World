// CrazeVerse Step 5 local account service interface.
namespace CrazeVerse.Services
{
    public interface IAuthService
    {
        bool IsLoggedIn { get; }
        string GetPlayerId();
        void StartGuestSession(string playerName);
        void EndSession();
    }
}
