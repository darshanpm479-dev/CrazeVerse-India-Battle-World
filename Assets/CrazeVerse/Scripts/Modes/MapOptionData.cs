namespace CrazeVerse.Modes
{
    [System.Serializable]
    public class MapOptionData
    {
        public string mapId;
        public string mapName;
        public string regionStyle;
        public string mood;
        public bool isUnlocked;
        public bool supportsGhostHunt;
        public bool supportsBattleRoyale;
        public bool supportsTDM;
        public bool supportsZombie;
        public bool supportsRace;

        public static MapOptionData[] CreateDefaultMaps()
        {
            // Fictional India-inspired maps only. Do not copy exact protected monuments or real layouts.
            // TODO: Expand to all 20 planned maps in a later content data step.
            return new[]
            {
                Create("MAP_HAMPI_NIGHT", "Hampi Ruins Night", "Karnataka ruins inspired", "Night mystery", true, true, false, false, false),
                Create("MAP_RAJASTHAN_FORT", "Rajasthan Haunted Fort", "Desert fort inspired", "Royal night", true, true, false, true, false),
                Create("MAP_KERALA_FOREST", "Kerala Forest Mansion", "Forest mansion inspired", "Rain forest", true, true, false, false, true),
                Create("MAP_VARANASI_GHAT", "Varanasi Ghat Darkness", "River ghat inspired", "Dark river", true, true, false, false, false),
                Create("MAP_OLD_DELHI_HAVELI", "Old Delhi Haveli", "Old city house inspired", "Urban mystery", true, true, false, true, false),
                Create("MAP_GOA_ISLAND", "Goa Island Battle", "Island coast inspired", "Sunny coast", false, true, false, false, true),
                Create("MAP_BENGALURU_TECH", "Bengaluru Tech Ruins", "Tech district inspired", "Neon ruins", false, true, true, false, false),
                Create("MAP_MYSORE_PALACE", "Mysore Palace Night", "Palace inspired", "Royal glow", true, false, true, false, false),
                Create("MAP_COORG_MIST", "Coorg Mist Forest", "Hill forest inspired", "Foggy forest", true, false, false, true, false),
                Create("MAP_KARNATAKA_VILLAGE", "Karnataka Village Night", "Village inspired", "Night village", true, false, false, false, false)
            };
        }

        private static MapOptionData Create(
            string mapId,
            string mapName,
            string regionStyle,
            string mood,
            bool supportsGhostHunt,
            bool supportsBattleRoyale,
            bool supportsTDM,
            bool supportsZombie,
            bool supportsRace)
        {
            return new MapOptionData
            {
                mapId = mapId,
                mapName = mapName,
                regionStyle = regionStyle,
                mood = mood,
                isUnlocked = true,
                supportsGhostHunt = supportsGhostHunt,
                supportsBattleRoyale = supportsBattleRoyale,
                supportsTDM = supportsTDM,
                supportsZombie = supportsZombie,
                supportsRace = supportsRace
            };
        }
    }
}
