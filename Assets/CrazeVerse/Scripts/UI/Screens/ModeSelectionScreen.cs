using CrazeVerse.Modes;

namespace CrazeVerse.UI
{
    public class ModeSelectionScreen : UIPageBase
    {
        public ModeSelectionController Controller;

        private void Awake()
        {
            ScreenId = ScreenId.ModeSelection;
        }

        public override void Refresh()
        {
            base.Refresh();

            if (Controller != null)
            {
                Controller.RefreshModeSelection();
            }
        }

        // TODO: Connect mode cards and local navigation when Unity Canvas is created later.
    }
}
