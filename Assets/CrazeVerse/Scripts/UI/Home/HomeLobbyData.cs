namespace CrazeVerse.UI
{
    [System.Serializable]
    public class HomeLobbyData
    {
        public string playerName;
        public int level;
        public int xp;
        public int coins;
        public string rank;
        public string selectedMode;
        public string selectedMap;
        public bool tutorialCompleted;
        public ModeCardData[] modeCards;
        public HomeQuickActionData[] quickActions;
        public NewsBannerData[] newsBanners;
        public DailyRewardPreviewData dailyReward;

        public static HomeLobbyData CreateDefault()
        {
            return new HomeLobbyData
            {
                playerName = "Guest Hunter",
                level = 1,
                xp = 0,
                coins = 500,
                rank = "Rookie",
                selectedMode = "Ghost Hunt Squad",
                selectedMap = "Hampi Ruins Night",
                tutorialCompleted = false,
                modeCards = ModeCardData.CreateDefaultCards(),
                quickActions = HomeQuickActionData.CreateDefaultActions(),
                newsBanners = NewsBannerData.CreateDefaultBanners(),
                dailyReward = DailyRewardPreviewData.CreateDefault()
            };
        }
    }
}
