using UnityEngine;

namespace CrazeVerse.UI
{
    public class UIScreenRouter : MonoBehaviour
    {
        private readonly UIStackHistory history = new UIStackHistory();

        public ScreenId CurrentScreen { get; private set; }

        public void Init()
        {
            // TODO: Register real UI pages in a later step.
            history.Clear();
            CurrentScreen = ScreenId.Splash;
        }

        public void NavigateTo(ScreenId screenId)
        {
            // TODO: Hide current page and show target page when real page references exist.
            if (CurrentScreen != screenId)
            {
                history.Push(CurrentScreen);
                CurrentScreen = screenId;
            }
        }

        public void GoBack()
        {
            // TODO: Connect back button and mobile back handling later.
            if (history.CanGoBack())
            {
                CurrentScreen = history.Pop();
            }
        }
    }
}
