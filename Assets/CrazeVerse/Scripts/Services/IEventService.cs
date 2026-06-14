// Step 5 local event interface.
namespace CrazeVerse.Services
{
    public interface IEventService
    {
        string GetActiveEventName();
        bool HasActiveEvent();
    }
}
