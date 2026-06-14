// CrazeVerse Step 7 local save manager. Local-only, no network or cloud dependency.
using UnityEngine;
using CrazeVerse.Services;

namespace CrazeVerse.Core
{
    public class SaveManager : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public LocalSaveData CurrentSave { get; private set; }

        public void Init()
        {
            CurrentSave = LoadSave();
            IsReady = true;
        }

        public LocalSaveData LoadSave()
        {
            CurrentSave = LocalSaveUtility.Load();
            if (CurrentSave == null)
            {
                CurrentSave = LocalSaveData.CreateDefault();
            }

            if (CurrentSave.playerProfile == null)
            {
                CurrentSave.playerProfile = LocalSaveData.CreateDefault().playerProfile;
            }

            return CurrentSave;
        }

        public void SaveNow()
        {
            LocalSaveUtility.Save(CurrentSave ?? LocalSaveData.CreateDefault());
        }

        public void ResetSave()
        {
            LocalSaveUtility.DeleteSave();
            CurrentSave = LocalSaveData.CreateDefault();
            SaveNow();
        }

        public bool HasSave()
        {
            return LocalSaveUtility.HasSave();
        }

        public PlayerProfileData GetProfile()
        {
            if (CurrentSave == null)
            {
                LoadSave();
            }

            return CurrentSave.playerProfile;
        }

        public void SetProfile(PlayerProfileData profile)
        {
            if (CurrentSave == null)
            {
                LoadSave();
            }

            CurrentSave.playerProfile = profile ?? LocalSaveData.CreateDefault().playerProfile;
            SaveNow();
        }
    }
}
