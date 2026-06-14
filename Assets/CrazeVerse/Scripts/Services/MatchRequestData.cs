// CrazeVerse Step 5 local-save-friendly data model.
namespace CrazeVerse.Services
{
    [System.Serializable]
    public class MatchRequestData
    {
        public string modeName;
        public string mapName;
        public int squadSize;
        public bool botFill;
    }
}
