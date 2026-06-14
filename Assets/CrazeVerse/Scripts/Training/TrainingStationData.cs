namespace CrazeVerse.Training
{
    [System.Serializable]
    public class TrainingStationData
    {
        public string stationId;
        public string stationName;
        public TrainingAreaType areaType;
        public string description;
        public bool isUnlocked;
        public string difficulty;

        public static TrainingStationData Create(string stationId, string stationName, TrainingAreaType areaType, string description, string difficulty)
        {
            return new TrainingStationData
            {
                stationId = stationId,
                stationName = stationName,
                areaType = areaType,
                description = description,
                isUnlocked = true,
                difficulty = difficulty
            };
        }

        public static TrainingStationData[] CreateDefaultStations()
        {
            return new[]
            {
                Create("movement_basics", "Movement Basics", TrainingAreaType.MovementZone, "Preview movement station planning data only.", "Easy"),
                Create("aim_practice", "Aim Practice", TrainingAreaType.AimZone, "Preview aim station planning data only.", "Easy"),
                Create("weapon_preview", "Weapon Preview", TrainingAreaType.WeaponZone, "Preview equipment station planning data only.", "Medium"),
                Create("spirit_scanner", "Spirit Scanner Practice", TrainingAreaType.GhostScannerZone, "Preview scanner station planning data only.", "Medium"),
                Create("zombie_wave_preview", "Zombie Wave Preview", TrainingAreaType.ZombieWavePreviewZone, "Preview wave station planning data only.", "Medium"),
                Create("vehicle_preview", "Vehicle Preview", TrainingAreaType.VehiclePreviewZone, "Preview transport station planning data only.", "Medium"),
                Create("squad_bot_preview", "Squad Bot Preview", TrainingAreaType.SquadBotPreviewZone, "Preview squad station planning data only.", "Easy"),
                Create("safe_zone_practice", "Safe Zone Practice", TrainingAreaType.SafeZonePractice, "Preview safe zone station planning data only.", "Easy")
            };
        }
    }
}
