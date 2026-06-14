// Step 5 local match request interface.
namespace CrazeVerse.Services
{
    public interface IMatchmakingService
    {
        MatchRequestData CreateRequest(string modeName, string mapName, int squadSize, bool botFill);
        bool IsSearching();
        void CancelSearch();
    }
}
