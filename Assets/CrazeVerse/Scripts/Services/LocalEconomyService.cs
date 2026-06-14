// Step 5 local mock service. No network calls.
namespace CrazeVerse.Services
{
    public class LocalEconomyService : IEconomyService
    {
        private int coins = 500;

        public int GetCoins() { return coins; }
        public void AddCoins(int amount) { coins += amount; }
        public bool SpendCoins(int amount)
        {
            if (amount > coins) { return false; }
            coins -= amount;
            return true;
        }
    }
}
