namespace CrazeVerse.UI
{
    public class HomeLobbyScreen : UIPageBase
    {
        public HomeLobbyController Controller;

        private void Awake()
        {
            ScreenId = ScreenId.HomeLobby;
        }

        public override void Refresh()
        {
            base.Refresh();

            if (Controller != null)
            {
                Controller.RefreshHome();
            }
        }

        // TODO: Connect lobby cards, player summary, and local data to real Unity UI later.
    }
}
