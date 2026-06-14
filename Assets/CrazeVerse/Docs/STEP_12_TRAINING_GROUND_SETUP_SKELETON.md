# Step 12 Training Ground Setup Skeleton

Step 12 adds Training Ground setup architecture only. It does not create a Unity scene, prefab, terrain, Canvas UI, real player movement, shooting, combat, enemy logic, vehicle logic, backend, Firebase, OpenAI API, payment, multiplayer, or APK.

## Added Training Architecture

- `TrainingAreaType` defines local practice area categories.
- `TrainingStationData` defines station cards such as Movement Basics, Aim Practice, Weapon Preview, Spirit Scanner Practice, Zombie Wave Preview, Vehicle Preview, Squad Bot Preview, and Safe Zone Practice.
- `TrainingSessionConfig` stores local preview session settings.
- `TrainingRuntimeState` stores local preview state.
- `TrainingObjectiveData` stores preview objective records.
- `TrainingStationRegistry` stores local station data only.
- `TrainingPlayerSpawnPlanner` stores spawn planning values only. It does not instantiate a player.
- `TrainingLoadoutPlanner` builds preview loadout data from existing local loadout data. It does not use weapons.
- `TrainingHUDData` stores planned HUD text data only. Because the exact file path was blocked, the class is stored in fallback file `TrainingDisplayData.cs`.
- `TrainingGroundSetupController` coordinates local setup state only.

## Updated Existing Files

- `TrainingGroundEntryController` now has an optional `TrainingGroundSetupController` reference and calls `StartTrainingPreview()` only as local state change.
- `TrainingGroundScreen` now has an optional training setup reference and calls `RefreshTrainingSetup()` during refresh.

## Local-Only Rules

- No Unity scene was created.
- No prefab was created.
- No real terrain or map was created.
- No CharacterController or Rigidbody movement was added.
- No shooting, projectiles, raycast hit detection, or combat loop was added.
- No ghost, zombie, vehicle, or enemy logic was added.
- No backend, Firebase, OpenAI API, payment, multiplayer, or APK work was added.

## Visual Direction

When real UI is created later, it must follow `UI_STYLE_GUIDE.md` and Canva Deck 1 to Deck 5.

## Next Step

Step 13 can be the Unity Editor compile check and local scene setup plan after approval.
