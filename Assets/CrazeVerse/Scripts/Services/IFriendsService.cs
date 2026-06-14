// Step 5 local social interface.
namespace CrazeVerse.Services
{
    public interface IFriendsService
    {
        int GetFriendCount();
        void AddMockFriend(string playerName);
    }
}
