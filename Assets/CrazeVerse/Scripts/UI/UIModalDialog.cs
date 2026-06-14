using UnityEngine;

namespace CrazeVerse.UI
{
    public class UIModalDialog : MonoBehaviour
    {
        public string CurrentTitle { get; private set; }
        public string CurrentMessage { get; private set; }

        public void ShowMessage(string title, string message)
        {
            CurrentTitle = title;
            CurrentMessage = message;
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            CurrentTitle = string.Empty;
            CurrentMessage = string.Empty;
            gameObject.SetActive(false);
        }
    }
}
