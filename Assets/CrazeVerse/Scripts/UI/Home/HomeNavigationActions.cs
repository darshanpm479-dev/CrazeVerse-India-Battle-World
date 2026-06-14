using UnityEngine;

namespace CrazeVerse.UI
{
    public class HomeNavigationActions : MonoBehaviour
    {
        public UIScreenRouter Router;

        public void OpenGhostHunt()
        {
            Router?.NavigateTo(ScreenId.GhostHuntMain);
        }

        public void OpenBattleRoyale()
        {
            Router?.NavigateTo(ScreenId.BattleRoyaleLobby);
        }

        public void OpenTDM()
        {
            Router?.NavigateTo(ScreenId.TDMLobby);
        }

        public void OpenZombieSurvival()
        {
            Router?.NavigateTo(ScreenId.ZombieSurvivalLobby);
        }

        public void OpenRaceBattle()
        {
            Router?.NavigateTo(ScreenId.RaceBattleLobby);
        }

        public void OpenCustomRoom()
        {
            Router?.NavigateTo(ScreenId.CustomRoom);
        }

        public void OpenTrainingGround()
        {
            Router?.NavigateTo(ScreenId.TrainingGround);
        }

        public void OpenProfile()
        {
            Router?.NavigateTo(ScreenId.Profile);
        }

        public void OpenShop()
        {
            Router?.NavigateTo(ScreenId.Shop);
        }

        public void OpenLeaderboard()
        {
            Router?.NavigateTo(ScreenId.Leaderboard);
        }

        public void OpenSettings()
        {
            Router?.NavigateTo(ScreenId.Settings);
        }
    }
}
