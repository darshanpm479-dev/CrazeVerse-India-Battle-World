# Step 7 Local Data Notes

This step adds local player data and local device storage planning for the Unity prototype.

## Added

- LocalSaveData for local player values, mode choice, map choice, tutorial flag, language, volume, and graphics quality.
- LocalSaveKeys for stable storage keys.
- LocalSaveUtility for PlayerPrefs and JsonUtility storage.
- SaveManager local data loading and saving.
- PlayerProfileManager guest profile setup and updates.
- EconomyManager local coin handling.
- RewardManager simple reward data creation.
- LocalProfileService and LocalAuthService were checked and kept local only.

## Local First Rule

This step uses local device storage only. It has no online service, no cloud system, no payment system, no external AI system, and no multiplayer server.

## Later Unity Review Plan

1. Start the game.
2. Create default guest profile.
3. Add XP.
4. Add coins.
5. Spend coins.
6. Save data.
7. Restart the game.
8. Load the same data.
9. Reset local data.
10. Confirm default profile returns.

## Not Added

No gameplay systems, no UI canvas, no Unity scenes, no APK, and no external service wiring were added.

## Next Step

Step 8 will create the Home Lobby and main page UI skeleton after approval.
