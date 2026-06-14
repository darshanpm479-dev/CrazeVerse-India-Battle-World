// Step 5 local inventory interface.
namespace CrazeVerse.Services
{
    public interface IInventoryService
    {
        bool HasItem(string itemId);
        void AddItem(string itemId);
    }
}
