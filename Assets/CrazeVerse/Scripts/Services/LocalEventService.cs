// Step 5 local mock service. No network calls.
namespace CrazeVerse.Services
{
    public class LocalEventService : IEventService
    {
        public string GetActiveEventName() { return "Local Launch Event"; }
        public bool HasActiveEvent() { return true; }
    }
}
