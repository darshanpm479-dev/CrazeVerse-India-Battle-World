using CrazeVerse.Modes;

namespace CrazeVerse.UI
{
    public class TrainingGroundScreen : UIPageBase
    {
        public TrainingGroundEntryController Controller;

        private void Awake()
        {
            ScreenId = ScreenId.TrainingGround;
        }

        public override void Refresh()
        {
            base.Refresh();

            if (Controller != null)
            {
                Controller.RefreshTrainingGround();
            }
        }

        // TODO: Connect training menu UI when Unity Canvas is created later.
    }
}
