using CrazeVerse.Modes;

namespace CrazeVerse.UI
{
    public class TrainingGroundScreen : UIPageBase
    {
        public TrainingGroundEntryController Controller;
        public CrazeVerse.Training.TrainingGroundSetupController TrainingSetup;

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

            if (TrainingSetup != null)
            {
                TrainingSetup.RefreshTrainingSetup();
            }
        }

        // TODO: Connect training page UI when Unity Canvas is created later.
    }
}
