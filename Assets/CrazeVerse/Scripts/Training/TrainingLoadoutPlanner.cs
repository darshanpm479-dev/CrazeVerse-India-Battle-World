using UnityEngine;
using CrazeVerse.Combat;

namespace CrazeVerse.Training
{
    public class TrainingLoadoutPlanner : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public WeaponLoadoutData PreviewLoadout { get; private set; }

        public void Init()
        {
            PreviewLoadout = BuildPreviewLoadout();
            IsReady = true;
        }

        public WeaponLoadoutData BuildPreviewLoadout()
        {
            return WeaponLoadoutData.CreateDefault();
        }

        public void RefreshLoadout()
        {
            EnsureReady();
            // TODO: Later approved steps can connect preview loadout to UI or scene setup.
        }

        private void EnsureReady()
        {
            if (!IsReady)
            {
                Init();
            }
        }
    }
}
