using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace CrazeVerse.Player
{
    public class CrazeVerseSimplePlayerMovement : MonoBehaviour
    {
        [Header("Movement")]
        public float moveSpeed = 6f;
        public float rotationSpeed = 12f;

        [Header("Camera")]
        public Transform cameraTransform;

        private CharacterController controller;

        private void Awake()
        {
            controller = GetComponent<CharacterController>();
            if (controller == null)
            {
                controller = gameObject.AddComponent<CharacterController>();
            }

            controller.height = 2f;
            controller.radius = 0.35f;
            controller.center = new Vector3(0f, 1f, 0f);

            if (cameraTransform == null && Camera.main != null)
            {
                cameraTransform = Camera.main.transform;
            }
        }

        private void Update()
        {
            Vector2 movementInput = ReadMovementInput();

            Vector3 inputDirection = new Vector3(movementInput.x, 0f, movementInput.y);
            if (inputDirection.sqrMagnitude > 1f)
            {
                inputDirection.Normalize();
            }

            if (inputDirection.magnitude >= 0.1f)
            {
                Vector3 cameraForward = Vector3.forward;
                Vector3 cameraRight = Vector3.right;

                if (cameraTransform != null)
                {
                    cameraForward = cameraTransform.forward;
                    cameraRight = cameraTransform.right;

                    cameraForward.y = 0f;
                    cameraRight.y = 0f;

                    cameraForward.Normalize();
                    cameraRight.Normalize();
                }

                Vector3 moveDirection = (cameraForward * inputDirection.z + cameraRight * inputDirection.x).normalized;

                controller.Move(moveDirection * moveSpeed * Time.deltaTime);

                Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }

            if (!controller.isGrounded)
            {
                controller.Move(Physics.gravity * Time.deltaTime);
            }
        }

        private Vector2 ReadMovementInput()
        {
            Vector2 input = Vector2.zero;

#if ENABLE_INPUT_SYSTEM
            Keyboard keyboard = Keyboard.current;
            if (keyboard != null)
            {
                if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
                {
                    input.y += 1f;
                }

                if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
                {
                    input.y -= 1f;
                }

                if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
                {
                    input.x += 1f;
                }

                if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
                {
                    input.x -= 1f;
                }
            }
#else
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");
#endif

            if (input.sqrMagnitude > 1f)
            {
                input.Normalize();
            }

            return input;
        }
    }
}
