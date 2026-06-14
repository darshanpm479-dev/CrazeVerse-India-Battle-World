using UnityEngine;

namespace CrazeVerse.UI
{
    public class TopBarView : MonoBehaviour
    {
        public string Title { get; private set; }
        public int Coins { get; private set; }
        public int Level { get; private set; }

        public void SetTitle(string title)
        {
            Title = title;
        }

        public void SetCoins(int coins)
        {
            Coins = coins;
        }

        public void SetLevel(int level)
        {
            Level = level;
        }
    }
}
