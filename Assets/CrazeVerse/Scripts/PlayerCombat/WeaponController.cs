using UnityEngine;

namespace CrazeVerse.Combat
{
    public class WeaponController : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public WeaponLoadoutData Loadout { get; private set; }
        public WeaponData CurrentWeapon { get; private set; }

        public void Init()
        {
            Loadout = WeaponLoadoutData.CreateDefault();
            CurrentWeapon = Loadout.primaryWeapon;
            IsReady = true;
        }

        public void EquipPrimary()
        {
            EnsureReady();
            SetCurrentWeapon(Loadout.primaryWeapon);
        }

        public void EquipSecondary()
        {
            EnsureReady();
            SetCurrentWeapon(Loadout.secondaryWeapon);
        }

        public void EquipSpecialTool()
        {
            EnsureReady();
            SetCurrentWeapon(Loadout.specialTool);
        }

        public void SetCurrentWeapon(WeaponData weapon)
        {
            EnsureReady();
            CurrentWeapon = weapon;
        }

        public bool CanUseCurrentWeapon()
        {
            EnsureReady();
            return CurrentWeapon != null && CurrentWeapon.isUnlocked;
        }

        public void RefreshWeaponState()
        {
            EnsureReady();
            // TODO: Later approved steps can connect this data to UI and match systems.
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
