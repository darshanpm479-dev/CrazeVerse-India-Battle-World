namespace CrazeVerse.Combat
{
    [System.Serializable]
    public class WeaponLoadoutData
    {
        public WeaponData primaryWeapon;
        public WeaponData secondaryWeapon;
        public WeaponData specialTool;

        public static WeaponLoadoutData CreateDefault()
        {
            return new WeaponLoadoutData
            {
                primaryWeapon = WeaponData.CreateDefault(WeaponType.AssaultRifle),
                secondaryWeapon = WeaponData.CreateDefault(WeaponType.Pistol),
                specialTool = WeaponData.CreateDefault(WeaponType.SpiritScanner)
            };
        }
    }
}
