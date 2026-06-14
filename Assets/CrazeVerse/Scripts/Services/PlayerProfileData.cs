// CrazeVerse Step 5 local-save-friendly data model.
namespace CrazeVerse.Services
{
    [System.Serializable]
    public class PlayerProfileData
    {
        public string playerId;
        public string playerName;
        public int level;
        public int xp;
        public int coins;
        public string rank;
    }
}
