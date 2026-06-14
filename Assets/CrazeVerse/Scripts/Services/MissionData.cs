// CrazeVerse Step 5 local-save-friendly data model.
namespace CrazeVerse.Services
{
    [System.Serializable]
    public class MissionData
    {
        public string missionId;
        public string missionName;
        public string mapName;
        public string difficulty;
        public string objective;
        public int rewardXP;
        public int rewardCoins;
    }
}
