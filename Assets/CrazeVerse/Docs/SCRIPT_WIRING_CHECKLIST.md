# Script Wiring Checklist

Use this only after Unity scripts compile with zero Console errors.

## Training Ground Wiring

- `TrainingGroundEntryController` -> `TrainingGroundSetupController`
- `TrainingGroundScreen` -> `TrainingGroundSetupController`
- `TrainingGroundSetupController` -> `TrainingStationRegistry`
- `TrainingGroundSetupController` -> `TrainingPlayerSpawnPlanner`
- `TrainingGroundSetupController` -> `TrainingLoadoutPlanner`
- `TrainingGroundSetupController` -> `LocalPlayerController`
- `TrainingGroundSetupController` -> `WeaponController`
- `TrainingGroundSetupController` -> `HealthController`
- `TrainingGroundSetupController` -> `InventoryController`

## UI Shell Wiring

- `MainMenuShell` -> `UIScreenRouter`
- `HomeLobbyScreen` -> `HomeLobbyController`
- `ModeSelectionScreen` -> `ModeSelectionController`

## Rule

Wire these references manually in the Inspector later. Do not add gameplay logic while wiring.
