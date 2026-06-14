using UnityEngine;
using CrazeVerse.Services;
using CrazeVerse.UI;

namespace CrazeVerse.Modes
{
    public class ModeSelectionController : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public GameModeData[] Modes { get; private set; }
        public MapOptionData[] Maps { get; private set; }
        public ModeSelectionState CurrentState { get; private set; }

        public void Init()
        {
            Modes = GameModeData.CreateDefaultModes();
            Maps = MapOptionData.CreateDefaultMaps();
            CurrentState = ModeSelectionState.CreateDefault();
            IsReady = true;
        }

        public void SelectMode(GameModeId modeId)
        {
            EnsureReady();

            if (Modes == null)
            {
                return;
            }

            foreach (GameModeData mode in Modes)
            {
                if (mode != null && mode.modeId == modeId)
                {
                    CurrentState.selectedMode = mode;
                    CurrentState.statusMessage = mode.isUnlocked ? "Ready" : "Locked";
                    CurrentState.isReadyToEnter = mode.isUnlocked;
                    SelectMap(mode.defaultMap);
                    return;
                }
            }
        }

        public void SelectMap(string mapName)
        {
            EnsureReady();

            if (Maps == null || string.IsNullOrEmpty(mapName))
            {
                return;
            }

            foreach (MapOptionData map in Maps)
            {
                if (map != null && map.mapName == mapName)
                {
                    CurrentState.selectedMap = map;
                    return;
                }
            }
        }

        public MatchRequestData BuildMatchRequest()
        {
            EnsureReady();

            GameModeData mode = CurrentState != null ? CurrentState.selectedMode : null;
            MapOptionData map = CurrentState != null ? CurrentState.selectedMap : null;

            int squadSize = mode != null ? mode.squadSize : 1;
            bool botFill = mode != null && mode.botFill;

            // Ghost Hunt Squad uses 48 as the clean advanced local planning max.
            // Future 50-player scaling is documentation-only until real server optimisation exists.
            return new MatchRequestData
            {
                modeName = mode != null ? mode.modeName : "Ghost Hunt Squad",
                mapName = map != null ? map.mapName : "Hampi Ruins Night",
                squadSize = squadSize,
                botFill = botFill
            };
        }

        public ScreenId GetSelectedTargetScreen()
        {
            EnsureReady();
            return CurrentState != null && CurrentState.selectedMode != null
                ? CurrentState.selectedMode.targetScreen
                : ScreenId.GhostHuntMain;
        }

        public void RefreshModeSelection()
        {
            EnsureReady();
            // TODO: Bind local mode data to UI cards when Unity Canvas is created later.
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
