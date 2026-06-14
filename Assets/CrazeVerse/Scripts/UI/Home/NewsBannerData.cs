namespace CrazeVerse.UI
{
    [System.Serializable]
    public class NewsBannerData
    {
        public string title;
        public string subtitle;
        public string tag;
        public ScreenId targetScreen;

        public static NewsBannerData[] CreateDefaultBanners()
        {
            return new[]
            {
                new NewsBannerData { title = "Ghost Hunt Squad Coming Soon", subtitle = "Local prototype planning is active", tag = "Mode", targetScreen = ScreenId.GhostHuntMain },
                new NewsBannerData { title = "Daily Rewards Ready", subtitle = "Preview local reward flow", tag = "Reward", targetScreen = ScreenId.DailyRewards },
                new NewsBannerData { title = "Training Ground Practice", subtitle = "Prepare controls and practice flow", tag = "Practice", targetScreen = ScreenId.TrainingGround }
            };
        }
    }
}
