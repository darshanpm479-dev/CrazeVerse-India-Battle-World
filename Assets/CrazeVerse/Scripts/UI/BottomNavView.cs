using UnityEngine;

namespace CrazeVerse.UI
{
    public class BottomNavView : MonoBehaviour
    {
        public bool IsVisible { get; private set; }
        public ScreenId SelectedTab { get; private set; }

        public void SelectTab(ScreenId screenId)
        {
            SelectedTab = screenId;
        }

        public void Show()
        {
            IsVisible = true;
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            IsVisible = false;
            gameObject.SetActive(false);
        }
    }
}
