// CrazeVerse Step 7 local save data model.
namespace CrazeVerse.Services
{
    [System.Serializable]
    public class LocalSaveData
    {
        public PlayerProfileData playerProfile;
        public int totalMatches;
        public int totalWins;
        public int totalKills;
        public string lastSelectedMode;
        public string lastSelectedMap;
        public bool tutorialCompleted;
        public string languageCode;
        public float masterVolume;
        public int graphicsQuality;

        public static LocalSaveData CreateDefault()
        {
            return new LocalSaveData
            {
                playerProfile = new PlayerProfileData
                {
                    playerId = "guest_local_001",
                    playerName = "Guest Hunter",
                    level = 1,
                    xp = 0,
                    coins = 500,
                    rank = "Rookie"
                },
                totalMatches = 0,
                totalWins = 0,
                totalKills = 0,
                lastSelectedMode = "Ghost Hunt Squad",
                lastSelectedMap = "Hampi Ruins Night",
                tutorialCompleted = false,
                languageCode = "en",
                masterVolume = 1f,
                graphicsQuality = 1
            };
        }
    }
}
