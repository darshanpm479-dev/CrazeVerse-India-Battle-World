namespace CrazeVerse.Combat
{
    [System.Serializable]
    public class WeaponData
    {
        public string weaponId;
        public string weaponName;
        public WeaponType weaponType;
        public DamageType damageType;
        public int basePower;
        public int maxAmmo;
        public int currentAmmo;
        public float range;
        public float cooldown;
        public bool isUnlocked;
        public bool isEquipped;

        public static WeaponData CreateDefault(WeaponType weaponType)
        {
            WeaponData data = new WeaponData
            {
                weaponId = weaponType.ToString(),
                weaponName = weaponType.ToString(),
                weaponType = weaponType,
                damageType = DamageType.Physical,
                basePower = 0,
                maxAmmo = 0,
                currentAmmo = 0,
                range = 0f,
                cooldown = 0.5f,
                isUnlocked = true,
                isEquipped = false
            };

            switch (weaponType)
            {
                case WeaponType.AssaultRifle:
                    data.weaponName = "Assault Rifle";
                    data.basePower = 25;
                    data.maxAmmo = 30;
                    data.currentAmmo = 30;
                    data.range = 60f;
                    break;
                case WeaponType.SMG:
                    data.weaponName = "SMG";
                    data.basePower = 18;
                    data.maxAmmo = 40;
                    data.currentAmmo = 40;
                    data.range = 40f;
                    break;
                case WeaponType.Shotgun:
                    data.weaponName = "Shotgun";
                    data.basePower = 60;
                    data.maxAmmo = 8;
                    data.currentAmmo = 8;
                    data.range = 18f;
                    break;
                case WeaponType.Sniper:
                    data.weaponName = "Sniper";
                    data.basePower = 90;
                    data.maxAmmo = 5;
                    data.currentAmmo = 5;
                    data.range = 120f;
                    break;
                case WeaponType.Pistol:
                    data.weaponName = "Pistol";
                    data.basePower = 20;
                    data.maxAmmo = 12;
                    data.currentAmmo = 12;
                    data.range = 35f;
                    break;
                case WeaponType.MeleeSword:
                    data.weaponName = "Melee Sword";
                    data.basePower = 35;
                    data.range = 2f;
                    break;
                case WeaponType.SacredLamp:
                    data.weaponName = "Sacred Lamp";
                    data.damageType = DamageType.Spirit;
                    data.basePower = 10;
                    data.range = 8f;
                    break;
                case WeaponType.SpiritScanner:
                    data.weaponName = "Spirit Scanner";
                    data.damageType = DamageType.Spirit;
                    data.basePower = 0;
                    data.range = 25f;
                    break;
            }

            return data;
        }
    }
}
