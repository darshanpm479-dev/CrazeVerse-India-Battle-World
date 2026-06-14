// Step 5 local mock service. No network calls.
namespace CrazeVerse.Services
{
    public class LocalCloudSaveService
    {
        public bool IsAvailable() { return false; }
        public void WriteText(string key, string value) { }
        public string ReadText(string key) { return string.Empty; }
    }
}
