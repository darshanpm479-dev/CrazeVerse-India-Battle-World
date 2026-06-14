// Step 5 local mock service. No network calls.
namespace CrazeVerse.Services
{
    public class LocalInventoryService : IInventoryService
    {
        private string ownedItemId = "starter_skin";

        public bool HasItem(string itemId) { return itemId == ownedItemId; }
        public void AddItem(string itemId) { ownedItemId = itemId; }
    }
}
