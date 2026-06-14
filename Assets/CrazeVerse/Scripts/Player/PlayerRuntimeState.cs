using UnityEngine;

namespace CrazeVerse.Player
{
    [System.Serializable]
    public class PlayerRuntimeState
    {
        public bool canMove;
        public bool isGrounded;
        public bool isSprinting;
        public bool isCrouching;
        public bool isInteracting;
        public float currentSpeed;
        public Vector3 velocity;
        public PlayerControlMode controlMode;

        public static PlayerRuntimeState CreateDefault()
        {
            return new PlayerRuntimeState
            {
                canMove = false,
                isGrounded = true,
                isSprinting = false,
                isCrouching = false,
                isInteracting = false,
                currentSpeed = 0f,
                velocity = Vector3.zero,
                controlMode = PlayerControlMode.None
            };
        }
    }
}
