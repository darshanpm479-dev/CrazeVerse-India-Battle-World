using UnityEngine;

namespace CrazeVerse.UI
{
    public class UILoadingOverlay : MonoBehaviour
    {
        public bool IsLoading { get; private set; }
        public string CurrentMessage { get; private set; }

        public void ShowLoading(string message)
        {
            CurrentMessage = message;
            IsLoading = true;
            gameObject.SetActive(true);
        }

        public void HideLoading()
        {
            IsLoading = false;
            CurrentMessage = string.Empty;
            gameObject.SetActive(false);
        }
    }
}
