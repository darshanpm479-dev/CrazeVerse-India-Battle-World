using CrazeVerse.UI;

namespace CrazeVerse.Modes
{
    [System.Serializable]
    public class GameModeData
    {
        public GameModeId modeId;
        public string modeName;
        public string subtitle;
        public string description;
        public ScreenId targetScreen;
        public int mvpMaxPlayers;
        public int advancedMaxPlayers;
        public int futureScalableMaxPlayers;
        public int squadSize;
        public bool botFill;
        public bool isUnlocked;
        public bool isFeatured;
        public string defaultMap;

        public static GameModeData[] CreateDefaultModes()
        {
            return new[]
            {
                new GameModeData
                {
                    modeId = GameModeId.GhostHuntSquad,
                    modeName = "Ghost Hunt Squad",
                    subtitle = "Multiple squads vs ghosts, cursed missions and escape",
                    description = "Flagship squad mission plan for the local prototype.",
                    targetScreen = ScreenId.GhostHuntMain,
                    mvpMaxPlayers = 24,
                    advancedMaxPlayers = 48,
                    futureScalableMaxPlayers = 50,
                    squadSize = 4,
                    botFill = true,
                    isUnlocked = true,
                    isFeatured = true,
                    defaultMap = "Hampi Ruins Night"
                },
                new GameModeData
                {
                    modeId = GameModeId.BattleRoyale,
                    modeName = "Battle Royale",
                    subtitle = "Large survival architecture with local bot fill first",
                    description = "Local prototype planning for solo, duo, and squad entry.",
                    targetScreen = ScreenId.BattleRoyaleLobby,
                    mvpMaxPlayers = 24,
                    advancedMaxPlayers = 100,
                    futureScalableMaxPlayers = 100,
                    squadSize = 4,
                    botFill = true,
                    isUnlocked = true,
                    isFeatured = false,
                    defaultMap = "Goa Island Battle"
                },
                new GameModeData
                {
                    modeId = GameModeId.TeamDeathmatch,
                    modeName = "Team Deathmatch",
                    subtitle = "5 vs 5 fast team match plan",
                    description = "Local entry skeleton for team match lobby.",
                    targetScreen = ScreenId.TDMLobby,
                    mvpMaxPlayers = 10,
                    advancedMaxPlayers = 10,
                    futureScalableMaxPlayers = 10,
                    squadSize = 5,
                    botFill = true,
                    isUnlocked = true,
                    isFeatured = false,
                    defaultMap = "Bengaluru Tech Ruins"
                },
                new GameModeData
                {
                    modeId = GameModeId.ZombieSurvival,
                    modeName = "Zombie Survival",
                    subtitle = "Four player wave survival plan",
                    description = "Local entry skeleton for wave survival lobby.",
                    targetScreen = ScreenId.ZombieSurvivalLobby,
                    mvpMaxPlayers = 4,
                    advancedMaxPlayers = 4,
                    futureScalableMaxPlayers = 4,
                    squadSize = 4,
                    botFill = true,
                    isUnlocked = true,
                    isFeatured = false,
                    defaultMap = "Kerala Forest Mansion"
                },
                new GameModeData
                {
                    modeId = GameModeId.RaceBattle,
                    modeName = "Race Battle",
                    subtitle = "Vehicle challenge mode planning",
                    description = "Local entry skeleton for race lobby.",
                    targetScreen = ScreenId.RaceBattleLobby,
                    mvpMaxPlayers = 12,
                    advancedMaxPlayers = 12,
                    futureScalableMaxPlayers = 12,
                    squadSize = 1,
                    botFill = true,
                    isUnlocked = true,
                    isFeatured = false,
                    defaultMap = "Goa Island Battle"
                },
                new GameModeData
                {
                    modeId = GameModeId.CustomRoom,
                    modeName = "Custom Room",
                    subtitle = "Private room planning for friends",
                    description = "Local entry skeleton for custom room settings.",
                    targetScreen = ScreenId.CustomRoom,
                    mvpMaxPlayers = 24,
                    advancedMaxPlayers = 48,
                    futureScalableMaxPlayers = 50,
                    squadSize = 4,
                    botFill = false,
                    isUnlocked = true,
                    isFeatured = false,
                    defaultMap = "Karnataka Village Night"
                },
                new GameModeData
                {
                    modeId = GameModeId.TrainingGround,
                    modeName = "Training Ground",
                    subtitle = "Practice area entry plan",
                    description = "Local entry skeleton for training options.",
                    targetScreen = ScreenId.TrainingGround,
                    mvpMaxPlayers = 1,
                    advancedMaxPlayers = 1,
                    futureScalableMaxPlayers = 1,
                    squadSize = 1,
                    botFill = false,
                    isUnlocked = true,
                    isFeatured = false,
                    defaultMap = "Training Ground"
                }
            };
        }
    }
}
