namespace CrazeVerse.UI
{
    [System.Serializable]
    public class HomeQuickActionData
    {
        public string actionName;
        public string description;
        public ScreenId targetScreen;
        public bool isEnabled;

        public static HomeQuickActionData[] CreateDefaultActions()
        {
            return new[]
            {
                new HomeQuickActionData { actionName = "Play Ghost Hunt", description = "Open the flagship mission lobby", targetScreen = ScreenId.GhostHuntMain, isEnabled = true },
                new HomeQuickActionData { actionName = "Training", description = "Open practice area", targetScreen = ScreenId.TrainingGround, isEnabled = true },
                new HomeQuickActionData { actionName = "Shop", description = "Open local cosmetic preview", targetScreen = ScreenId.Shop, isEnabled = true },
                new HomeQuickActionData { actionName = "Leaderboard", description = "Open local ranking preview", targetScreen = ScreenId.Leaderboard, isEnabled = true },
                new HomeQuickActionData { actionName = "Settings", description = "Open local settings", targetScreen = ScreenId.Settings, isEnabled = true }
            };
        }
    }
}
