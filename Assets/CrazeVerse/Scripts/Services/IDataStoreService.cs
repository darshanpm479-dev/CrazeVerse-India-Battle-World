// Step 5 local data interface.
namespace CrazeVerse.Services
{
    public interface IDataStoreService
    {
        bool IsAvailable();
        void WriteText(string key, string value);
        string ReadText(string key);
    }
}
