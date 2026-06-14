// Step 5 local analytics interface.
namespace CrazeVerse.Services
{
    public interface IAnalyticsService
    {
        void RecordEvent(string eventName);
    }
}
