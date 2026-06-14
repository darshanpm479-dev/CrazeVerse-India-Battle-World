// CrazeVerse Step 7 local economy manager. Local mock coins only.
using UnityEngine;

namespace CrazeVerse.Core
{
    public class EconomyManager : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public int Coins { get; private set; }

        public void Init()
        {
            Coins = Mathf.Max(0, Coins);
            IsReady = true;
        }

        public void SetCoins(int coins)
        {
            Coins = Mathf.Max(0, coins);
        }

        public void AddCoins(int amount)
        {
            if (amount <= 0)
            {
                return;
            }

            Coins += amount;
        }

        public bool SpendCoins(int amount)
        {
            if (amount <= 0)
            {
                return true;
            }

            if (Coins < amount)
            {
                return false;
            }

            Coins -= amount;
            return true;
        }
    }
}
