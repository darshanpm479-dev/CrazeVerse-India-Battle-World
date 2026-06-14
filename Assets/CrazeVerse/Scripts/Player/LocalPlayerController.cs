using UnityEngine;

namespace CrazeVerse.Player
{
    public class LocalPlayerController : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public PlayerInputReader InputReader;
        public PlayerMovementConfig MovementConfig { get; private set; }
        public PlayerRuntimeState RuntimeState { get; private set; }

        public void Init()
        {
            MovementConfig = PlayerMovementConfig.CreateDefault();
            RuntimeState = PlayerRuntimeState.CreateDefault();

            if (InputReader != null)
            {
                InputReader.Init();
            }

            IsReady = true;
        }

        public void SetControlMode(PlayerControlMode mode)
        {
            EnsureReady();
            RuntimeState.controlMode = mode;
        }

        public void SetMovementEnabled(bool enabled)
        {
            EnsureReady();
            RuntimeState.canMove = enabled;
        }

        public void ApplyInput(PlayerInputData inputData)
        {
            EnsureReady();

            PlayerInputData safeInput = inputData ?? PlayerInputData.CreateEmpty();
            RuntimeState.isSprinting = safeInput.sprintHeld;
            RuntimeState.isCrouching = safeInput.crouchHeld;
            RuntimeState.isInteracting = safeInput.interactPressed;
            RuntimeState.currentSpeed = CalculatePreviewSpeed(safeInput);

            // TODO: Real movement physics will be added only in a later approved step.
        }

        public void TeleportTo(Vector3 position)
        {
            transform.position = position;
        }

        public void ResetPlayerState()
        {
            RuntimeState = PlayerRuntimeState.CreateDefault();
        }

        private float CalculatePreviewSpeed(PlayerInputData inputData)
        {
            if (MovementConfig == null || inputData == null || inputData.moveAxis.sqrMagnitude <= 0f)
            {
                return 0f;
            }

            if (inputData.crouchHeld)
            {
                return MovementConfig.crouchSpeed;
            }

            return inputData.sprintHeld ? MovementConfig.sprintSpeed : MovementConfig.walkSpeed;
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
