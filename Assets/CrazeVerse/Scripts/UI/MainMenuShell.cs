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
        public HomeLobbyController HomeLobbyController;

        public void Init()
        {
            if (Router != null)
            {
                Router.Init();
            }

            if (HomeLobbyController != null)
            {
                HomeLobbyController.Init();
            }
        }

        public void OpenHome()
        {
            Router?.NavigateTo(ScreenId.HomeLobby);
            HomeLobbyController?.RefreshHome();
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
