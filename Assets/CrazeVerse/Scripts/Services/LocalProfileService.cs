// Step 5 local mock service. No network calls.
namespace CrazeVerse.Services
{
    public class LocalProfileService : IProfileService
    {
        private PlayerProfileData profile = new PlayerProfileData
        {
            playerId = "guest_local_001",
            playerName = "Guest Hunter",
            level = 1,
            xp = 0,
            coins = 500,
            rank = "Rookie"
        };

        public PlayerProfileData ReadProfile() { return profile; }
        public void StoreProfile(PlayerProfileData profileData) { profile = profileData; }
    }
}
