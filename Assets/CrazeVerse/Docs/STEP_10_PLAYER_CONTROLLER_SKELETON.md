# Step 10 Player Controller Skeleton

Step 10 adds the local player controller architecture skeleton for future Training Ground and match prototype work.

## Added

- PlayerControlMode defines local control states: None, LobbyPreview, TrainingGround, and MatchPreview.
- PlayerInputData stores future input values using UnityEngine Vector2 and simple action flags.
- PlayerMovementConfig stores basic movement tuning values for later approved movement work.
- PlayerRuntimeState stores local runtime state such as canMove, grounded, sprinting, crouching, currentSpeed, velocity, and control mode.
- PlayerInputReader stores mock input data only and has no Input System package dependency.
- LocalPlayerController stores config and runtime state, applies mock input to state only, and does not move physics objects.
- PlayerCameraTarget provides a simple target position helper.
- ThirdPersonCameraRig provides a camera follow skeleton with no Cinemachine dependency.
- PlayerSpawnPoint provides spawn position and rotation helpers.
- PlayerAnimationBridge provides animation hook methods with TODO comments only.

## Existing File Updated

- TrainingGroundEntryController now notes that player controller skeleton wiring will happen later.

## Not Added

- No real movement physics was added.
- No CharacterController movement was added.
- No Rigidbody movement was added.
- No mobile joystick was added.
- No shooting, weapons, or combat was added.
- No ghost, zombie, or vehicle logic was added.
- No Unity scenes, Canvas UI, or prefabs were added.
- No backend, Firebase, OpenAI API, payment, multiplayer, or APK work was added.

## Review Notes

These scripts are architecture skeletons only. They are intended to compile in Unity and be wired later in approved steps.

## Next Step

Step 11 will create the weapon, health, and inventory skeleton after approval.
