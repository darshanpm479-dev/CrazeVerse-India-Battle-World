namespace CrazeVerse.UI
{
    [System.Serializable]
    public class DailyRewardPreviewData
    {
        public string rewardName;
        public int rewardCoins;
        public int rewardXP;
        public bool canClaim;

        public static DailyRewardPreviewData CreateDefault()
        {
            return new DailyRewardPreviewData
            {
                rewardName = "Daily Hunter Bonus",
                rewardCoins = 100,
                rewardXP = 50,
                canClaim = true
            };
        }
    }
}
