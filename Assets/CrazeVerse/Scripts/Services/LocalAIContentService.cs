// Step 5 local mock service. Uses offline text only.
namespace CrazeVerse.Services
{
    public class LocalAIContentService : IAIContentService
    {
        public string GetMissionHint(string missionId) { return "Search clues, stay with squad, and reach the escape gate."; }
        public string GetEventStorySeed() { return "A local seasonal adventure begins."; }
    }
}
