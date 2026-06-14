// CrazeVerse Step 7 local reward manager. No gameplay reward calculation yet.
using UnityEngine;
using CrazeVerse.Services;

namespace CrazeVerse.Core
{
    public class RewardManager : MonoBehaviour
    {
        public bool IsReady { get; private set; }

        public void Init()
        {
            IsReady = true;
        }

        public RewardData CreateReward(string rewardName, int xp, int coins)
        {
            return new RewardData
            {
                rewardName = string.IsNullOrWhiteSpace(rewardName) ? "Local Reward" : rewardName,
                rewardXP = Mathf.Max(0, xp),
                rewardCoins = Mathf.Max(0, coins)
            };
        }
    }
}
