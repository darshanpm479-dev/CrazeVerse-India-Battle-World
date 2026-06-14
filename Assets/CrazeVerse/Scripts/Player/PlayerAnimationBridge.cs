using UnityEngine;

namespace CrazeVerse.Player
{
    public class PlayerAnimationBridge : MonoBehaviour
    {
        public bool IsReady { get; private set; }

        public void Init()
        {
            IsReady = true;
        }

        public void SetMoveSpeed(float speed)
        {
            // TODO: Connect move speed to Animator parameters in a later approved step.
        }

        public void SetGrounded(bool grounded)
        {
            // TODO: Connect grounded state to Animator parameters in a later approved step.
        }

        public void SetCrouching(bool crouching)
        {
            // TODO: Connect crouch state to Animator parameters in a later approved step.
        }

        public void TriggerJump()
        {
            // TODO: Trigger jump animation in a later approved step.
        }

        public void TriggerInteract()
        {
            // TODO: Trigger interaction animation in a later approved step.
        }
    }
}
