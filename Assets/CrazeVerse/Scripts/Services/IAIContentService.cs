// Step 5 offline content interface with future upgrade path.
namespace CrazeVerse.Services
{
    public interface IAIContentService
    {
        string GetMissionHint(string missionId);
        string GetEventStorySeed();
    }
}
