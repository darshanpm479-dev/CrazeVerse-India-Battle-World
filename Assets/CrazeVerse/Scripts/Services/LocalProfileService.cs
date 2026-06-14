// CrazeVerse Step 7 local profile service. Local mock data only, no network or cloud.
namespace CrazeVerse.Services
{
    public class LocalProfileService : IProfileService
    {
        private PlayerProfileData profile;

        public LocalProfileService()
        {
            profile = LocalSaveData.CreateDefault().playerProfile;
        }

        public PlayerProfileData ReadProfile()
        {
            if (profile == null)
            {
                profile = LocalSaveData.CreateDefault().playerProfile;
            }

            return profile;
        }

        public void StoreProfile(PlayerProfileData profileData)
        {
            profile = profileData ?? LocalSaveData.CreateDefault().playerProfile;
        }
    }
}
