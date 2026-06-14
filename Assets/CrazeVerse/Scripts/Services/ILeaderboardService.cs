// Step 5 local leaderboard interface.
namespace CrazeVerse.Services
{
    public interface ILeaderboardService
    {
        int GetLocalRank(string boardName);
        string GetTopPlayerName(string boardName);
    }
}
