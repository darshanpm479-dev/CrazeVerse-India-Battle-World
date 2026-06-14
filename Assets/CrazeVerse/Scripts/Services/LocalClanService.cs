// Step 5 local mock service. No network calls.
namespace CrazeVerse.Services
{
    public class LocalClanService : IClanService
    {
        private string groupName = "No Group";

        public string GetGroupName() { return groupName; }
        public void SetGroupName(string value) { groupName = value; }
    }
}
