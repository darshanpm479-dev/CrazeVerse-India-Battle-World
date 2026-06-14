namespace CrazeVerse.UI
{
    [System.Serializable]
    public class ModeCardData
    {
        public string modeName;
        public string subtitle;
        public ScreenId targetScreen;
        public bool isUnlocked;
        public bool isFeatured;
        public string badgeText;

        public static ModeCardData[] CreateDefaultCards()
        {
            return new[]
            {
                new ModeCardData { modeName = "Ghost Hunt Squad", subtitle = "Flagship squad mission mode", targetScreen = ScreenId.GhostHuntMain, isUnlocked = true, isFeatured = true, badgeText = "Featured" },
                new ModeCardData { modeName = "Battle Royale", subtitle = "Large survival mode plan", targetScreen = ScreenId.BattleRoyaleLobby, isUnlocked = true, isFeatured = false, badgeText = "Prototype" },
                new ModeCardData { modeName = "Team Deathmatch", subtitle = "Fast team match plan", targetScreen = ScreenId.TDMLobby, isUnlocked = true, isFeatured = false, badgeText = "5v5" },
                new ModeCardData { modeName = "Zombie Survival", subtitle = "Wave practice plan", targetScreen = ScreenId.ZombieSurvivalLobby, isUnlocked = true, isFeatured = false, badgeText = "Co-op" },
                new ModeCardData { modeName = "Race Battle", subtitle = "Vehicle challenge plan", targetScreen = ScreenId.RaceBattleLobby, isUnlocked = true, isFeatured = false, badgeText = "Race" },
                new ModeCardData { modeName = "Custom Room", subtitle = "Private room plan", targetScreen = ScreenId.CustomRoom, isUnlocked = true, isFeatured = false, badgeText = "Friends" },
                new ModeCardData { modeName = "Training Ground", subtitle = "Practice and tutorial area", targetScreen = ScreenId.TrainingGround, isUnlocked = true, isFeatured = false, badgeText = "Practice" }
            };
        }
    }
}
