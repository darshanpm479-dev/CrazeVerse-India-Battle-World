using UnityEngine;

namespace CrazeVerse.UI
{
    public class MainMenuShell : MonoBehaviour
    {
        public TopBarView TopBar;
        public BottomNavView BottomNav;
        public UILoadingOverlay LoadingOverlay;
        public UIModalDialog ModalDialog;
        public UIScreenRouter Router;

        public void Init()
        {
            // TODO: Wire these references from Unity scene or prefab in a later step.
            if (Router != null)
            {
                Router.Init();
            }
        }

        public void OpenHome()
        {
            Router?.NavigateTo(ScreenId.HomeLobby);
        }

        public void OpenModes()
        {
            Router?.NavigateTo(ScreenId.ModeSelection);
        }

        public void OpenProfile()
        {
            Router?.NavigateTo(ScreenId.Profile);
        }

        public void OpenSettings()
        {
            Router?.NavigateTo(ScreenId.Settings);
        }
    }
}
