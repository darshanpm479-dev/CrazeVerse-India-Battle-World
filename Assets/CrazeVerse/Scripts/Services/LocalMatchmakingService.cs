// Step 5 local mock service. No network calls.
namespace CrazeVerse.Services
{
    public class LocalMatchmakingService : IMatchmakingService
    {
        private bool searching;

        public MatchRequestData CreateRequest(string modeName, string mapName, int squadSize, bool botFill)
        {
            searching = true;
            return new MatchRequestData { modeName = modeName, mapName = mapName, squadSize = squadSize, botFill = botFill };
        }

        public bool IsSearching() { return searching; }
        public void CancelSearch() { searching = false; }
    }
}
