// Step 5 local mock service. No network calls.
namespace CrazeVerse.Services
{
    public class LocalDataStoreService : IDataStoreService
    {
        private string lastKey = string.Empty;
        private string lastValue = string.Empty;

        public bool IsAvailable() { return true; }
        public void WriteText(string key, string value) { lastKey = key; lastValue = value; }
        public string ReadText(string key) { return key == lastKey ? lastValue : string.Empty; }
    }
}
