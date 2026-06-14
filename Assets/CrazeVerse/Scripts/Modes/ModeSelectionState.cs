namespace CrazeVerse.Modes
{
    [System.Serializable]
    public class ModeSelectionState
    {
        public GameModeData selectedMode;
        public MapOptionData selectedMap;
        public bool isReadyToEnter;
        public string statusMessage;

        public static ModeSelectionState CreateDefault()
        {
            GameModeData[] modes = GameModeData.CreateDefaultModes();
            MapOptionData[] maps = MapOptionData.CreateDefaultMaps();

            return new ModeSelectionState
            {
                selectedMode = modes != null && modes.Length > 0 ? modes[0] : null,
                selectedMap = maps != null && maps.Length > 0 ? maps[0] : null,
                isReadyToEnter = true,
                statusMessage = "Ready"
            };
        }
    }
}
