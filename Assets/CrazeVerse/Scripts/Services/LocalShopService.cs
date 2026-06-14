// Step 5 local mock service. No network calls.
namespace CrazeVerse.Services
{
    public class LocalShopService : IShopService
    {
        public bool BuyCosmetic(string itemId) { return true; }
        public string GetFeaturedItemId() { return "starter_outfit"; }
    }
}
