// Step 5 local shop interface.
namespace CrazeVerse.Services
{
    public interface IShopService
    {
        bool BuyCosmetic(string itemId);
        string GetFeaturedItemId();
    }
}
