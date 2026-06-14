// Step 5 local mock service. No network calls.
namespace CrazeVerse.Services
{
    public class LocalFriendsService : IFriendsService
    {
        private int friendCount;

        public int GetFriendCount() { return friendCount; }
        public void AddMockFriend(string playerName) { friendCount++; }
    }
}
