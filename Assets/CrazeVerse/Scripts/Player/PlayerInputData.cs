using UnityEngine;

namespace CrazeVerse.Player
{
    [System.Serializable]
    public class PlayerInputData
    {
        public Vector2 moveAxis;
        public Vector2 lookAxis;
        public bool jumpPressed;
        public bool sprintHeld;
        public bool crouchHeld;
        public bool interactPressed;
        public bool primaryActionPressed;

        public static PlayerInputData CreateEmpty()
        {
            return new PlayerInputData
            {
                moveAxis = Vector2.zero,
                lookAxis = Vector2.zero,
                jumpPressed = false,
                sprintHeld = false,
                crouchHeld = false,
                interactPressed = false,
                primaryActionPressed = false
            };
        }

        public void ClearActions()
        {
            jumpPressed = false;
            interactPressed = false;
            primaryActionPressed = false;
        }
    }
}
