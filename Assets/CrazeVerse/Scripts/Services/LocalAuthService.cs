// CrazeVerse Step 7 local auth service. Guest/local session only.
namespace CrazeVerse.Services
{
    public class LocalAuthService : IAuthService
    {
        public bool IsLoggedIn { get; private set; }
        private string playerId = "guest_local_001";

        public string GetPlayerId()
        {
            return string.IsNullOrWhiteSpace(playerId) ? "guest_local_001" : playerId;
        }

        public void StartGuestSession(string playerName)
        {
            IsLoggedIn = true;
            playerId = "guest_local_001";
        }

        public void EndSession()
        {
            IsLoggedIn = false;
        }
    }
}
