// Step 5 local mock service. No network calls.
namespace CrazeVerse.Services
{
    public class LocalAuthService : IAuthService
    {
        public bool IsLoggedIn { get; private set; }
        private string playerId = "guest_local_001";

        public string GetPlayerId() { return playerId; }
        public void StartGuestSession(string playerName) { IsLoggedIn = true; }
        public void EndSession() { IsLoggedIn = false; }
    }
}
