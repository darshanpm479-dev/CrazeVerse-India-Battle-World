using UnityEngine;

namespace CrazeVerse.Player
{
    public class PlayerInputReader : MonoBehaviour
    {
        public bool IsEnabled { get; private set; }
        public PlayerInputData CurrentInput { get; private set; }

        public void Init()
        {
            CurrentInput = PlayerInputData.CreateEmpty();
            IsEnabled = false;
        }

        public void EnableInput()
        {
            IsEnabled = true;
        }

        public void DisableInput()
        {
            IsEnabled = false;
            ClearInput();
        }

        public void SetMockInput(PlayerInputData inputData)
        {
            CurrentInput = inputData ?? PlayerInputData.CreateEmpty();
        }

        public void ClearInput()
        {
            CurrentInput = PlayerInputData.CreateEmpty();
        }
    }
}
