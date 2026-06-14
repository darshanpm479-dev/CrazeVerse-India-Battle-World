namespace CrazeVerse.Training
{
    [System.Serializable]
    public class TrainingHUDData
    {
        public string title;
        public string subtitle;
        public string objectiveText;
        public string statusText;
        public bool showControlsHint;
        public bool showExitButton;

        public static TrainingHUDData CreateDefault()
        {
            return new TrainingHUDData
            {
                title = "Training Ground",
                subtitle = "Local practice setup",
                objectiveText = "Select a training station",
                statusText = "Ready",
                showControlsHint = true,
                showExitButton = true
            };
        }
    }
}
