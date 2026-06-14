// Step 5 profile service interface.
namespace CrazeVerse.Services
{
    public interface IProfileService
    {
        PlayerProfileData ReadProfile();
        void StoreProfile(PlayerProfileData profile);
    }
}
