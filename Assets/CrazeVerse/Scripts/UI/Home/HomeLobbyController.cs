using UnityEngine;
using CrazeVerse.Services;
using CrazeVerse.Core;

namespace CrazeVerse.UI
{
    public class HomeLobbyController : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public HomeLobbyData CurrentHomeData { get; private set; }

        public void Init()
        {
            CurrentHomeData = HomeLobbyData.CreateDefault();
            IsReady = true;
        }

        public void BuildFromSave(LocalSaveData saveData)
        {
            CurrentHomeData = HomeLobbyData.CreateDefault();

            if (saveData == null)
            {
                return;
            }

            if (saveData.playerProfile != null)
            {
                SetPlayerSummary(
                    saveData.playerProfile.playerName,
                    saveData.playerProfile.level,
                    saveData.playerProfile.xp,
                    saveData.playerProfile.coins,
                    saveData.playerProfile.rank);
            }

            SelectMode(saveData.lastSelectedMode);
            SelectMap(saveData.lastSelectedMap);
            CurrentHomeData.tutorialCompleted = saveData.tutorialCompleted;
        }

        public void SetPlayerSummary(string playerName, int level, int xp, int coins, string rank)
        {
            EnsureHomeData();
            CurrentHomeData.playerName = string.IsNullOrWhiteSpace(playerName) ? "Guest Hunter" : playerName;
            CurrentHomeData.level = Mathf.Max(1, level);
            CurrentHomeData.xp = Mathf.Max(0, xp);
            CurrentHomeData.coins = Mathf.Max(0, coins);
            CurrentHomeData.rank = string.IsNullOrWhiteSpace(rank) ? "Rookie" : rank;
        }

        public void SelectMode(string modeName)
        {
            EnsureHomeData();
            CurrentHomeData.selectedMode = string.IsNullOrWhiteSpace(modeName) ? "Ghost Hunt Squad" : modeName;
        }

        public void SelectMap(string mapName)
        {
            EnsureHomeData();
            CurrentHomeData.selectedMap = string.IsNullOrWhiteSpace(mapName) ? "Hampi Ruins Night" : mapName;
        }

        public void RefreshHome()
        {
            EnsureHomeData();
            // TODO: Bind CurrentHomeData into Unity UI components in a later visual UI step.
        }

        public ModeCardData[] BuildDefaultModeCards()
        {
            return ModeCardData.CreateDefaultCards();
        }

        public HomeQuickActionData[] BuildDefaultQuickActions()
        {
            return HomeQuickActionData.CreateDefaultActions();
        }

        public NewsBannerData[] BuildDefaultNewsBanners()
        {
            return NewsBannerData.CreateDefaultBanners();
        }

        public DailyRewardPreviewData BuildDefaultDailyReward()
        {
            return DailyRewardPreviewData.CreateDefault();
        }

        private void EnsureHomeData()
        {
            if (CurrentHomeData == null)
            {
                CurrentHomeData = HomeLobbyData.CreateDefault();
            }
        }
    }
}
