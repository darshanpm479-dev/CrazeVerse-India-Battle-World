namespace CrazeVerse.Player
{
    [System.Serializable]
    public class PlayerMovementConfig
    {
        public float walkSpeed;
        public float sprintSpeed;
        public float crouchSpeed;
        public float rotationSpeed;
        public float jumpHeight;
        public float gravity;
        public float groundedCheckDistance;

        public static PlayerMovementConfig CreateDefault()
        {
            return new PlayerMovementConfig
            {
                walkSpeed = 4f,
                sprintSpeed = 7f,
                crouchSpeed = 2f,
                rotationSpeed = 12f,
                jumpHeight = 1.2f,
                gravity = -20f,
                groundedCheckDistance = 0.25f
            };
        }
    }
}
