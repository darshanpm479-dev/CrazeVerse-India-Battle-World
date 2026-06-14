using UnityEngine;

namespace CrazeVerse.UI
{
    public class UIPageBase : MonoBehaviour
    {
        public ScreenId ScreenId;
        public bool IsVisible { get; private set; }

        public virtual void Show()
        {
            IsVisible = true;
            gameObject.SetActive(true);
        }

        public virtual void Hide()
        {
            IsVisible = false;
            gameObject.SetActive(false);
        }

        public virtual void Refresh()
        {
            // TODO: Refresh page data in a later UI wiring step.
        }
    }
}
