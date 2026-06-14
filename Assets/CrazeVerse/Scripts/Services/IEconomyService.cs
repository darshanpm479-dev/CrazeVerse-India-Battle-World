// Step 5 local economy interface.
namespace CrazeVerse.Services
{
    public interface IEconomyService
    {
        int GetCoins();
        void AddCoins(int amount);
        bool SpendCoins(int amount);
    }
}
