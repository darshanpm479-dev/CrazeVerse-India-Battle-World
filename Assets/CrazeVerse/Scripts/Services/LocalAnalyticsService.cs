// Step 5 local mock service. No network calls.
namespace CrazeVerse.Services
{
    public class LocalAnalyticsService : IAnalyticsService
    {
        public void RecordEvent(string eventName) { }
    }
}
