// Step 5 local mock service. No network calls.
namespace CrazeVerse.Services
{
    public class LocalLeaderboardService : ILeaderboardService
    {
        public int GetLocalRank(string boardName) { return 1; }
        public string GetTopPlayerName(string boardName) { return "Guest Hunter"; }
    }
}
