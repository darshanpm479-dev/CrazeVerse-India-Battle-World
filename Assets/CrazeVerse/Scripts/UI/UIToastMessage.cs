using UnityEngine;

namespace CrazeVerse.UI
{
    public class UIToastMessage : MonoBehaviour
    {
        public string CurrentMessage { get; private set; }
        public bool IsVisible { get; private set; }

        public void ShowToast(string message)
        {
            CurrentMessage = message;
            IsVisible = true;
            gameObject.SetActive(true);
        }

        public void HideToast()
        {
            CurrentMessage = string.Empty;
            IsVisible = false;
            gameObject.SetActive(false);
        }
    }
}
