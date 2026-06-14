namespace CrazeVerse.Training
{
    [System.Serializable]
    public class TrainingDisplayData
    {
        public string title;
        public string subtitle;
        public string objectiveText;
        public string statusText;
        public bool showControlsHint;
        public bool showExitButton;

        public static TrainingDisplayData CreateDefault()
        {
            return new TrainingDisplayData
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
