// CrazeVerse Step 7 local player profile manager. Guest/local profile only.
using UnityEngine;
using CrazeVerse.Services;

namespace CrazeVerse.Core
{
    public class PlayerProfileManager : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public PlayerProfileData CurrentProfile { get; private set; }

        public void Init()
        {
            CurrentProfile = CreateGuestProfile();
            IsReady = true;
        }

        public void LoadFromSave(LocalSaveData saveData)
        {
            CurrentProfile = saveData != null && saveData.playerProfile != null
                ? saveData.playerProfile
                : CreateGuestProfile();
        }

        public PlayerProfileData CreateGuestProfile()
        {
            return new PlayerProfileData
            {
                playerId = "guest_local_001",
                playerName = "Guest Hunter",
                level = 1,
                xp = 0,
                coins = 500,
                rank = "Rookie"
            };
        }

        public void SetPlayerName(string playerName)
        {
            EnsureProfile();
            CurrentProfile.playerName = string.IsNullOrWhiteSpace(playerName) ? "Guest Hunter" : playerName;
        }

        public void AddXP(int amount)
        {
            EnsureProfile();
            if (amount <= 0)
            {
                return;
            }

            CurrentProfile.xp += amount;
            CurrentProfile.level = Mathf.Max(1, 1 + (CurrentProfile.xp / 1000));
        }

        public void AddCoins(int amount)
        {
            EnsureProfile();
            if (amount <= 0)
            {
                return;
            }

            CurrentProfile.coins += amount;
        }

        public bool SpendCoins(int amount)
        {
            EnsureProfile();
            if (amount <= 0)
            {
                return true;
            }

            if (CurrentProfile.coins < amount)
            {
                return false;
            }

            CurrentProfile.coins -= amount;
            return true;
        }

        public void SetRank(string rank)
        {
            EnsureProfile();
            CurrentProfile.rank = string.IsNullOrWhiteSpace(rank) ? "Rookie" : rank;
        }

        private void EnsureProfile()
        {
            if (CurrentProfile == null)
            {
                CurrentProfile = CreateGuestProfile();
            }

            CurrentProfile.xp = Mathf.Max(0, CurrentProfile.xp);
            CurrentProfile.coins = Mathf.Max(0, CurrentProfile.coins);
        }
    }
}
