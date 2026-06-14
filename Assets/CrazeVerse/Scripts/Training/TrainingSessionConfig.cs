namespace CrazeVerse.Training
{
    [System.Serializable]
    public class TrainingSessionConfig
    {
        public string sessionName;
        public string selectedStationId;
        public bool allowMockInput;
        public bool allowPreviewWeapons;
        public bool allowPreviewHealth;
        public bool allowPreviewInventory;
        public int sessionMinutes;

        public static TrainingSessionConfig CreateDefault()
        {
            return new TrainingSessionConfig
            {
                sessionName = "Training Ground Local Preview",
                selectedStationId = "movement_basics",
                allowMockInput = true,
                allowPreviewWeapons = true,
                allowPreviewHealth = true,
                allowPreviewInventory = true,
                sessionMinutes = 10
            };
        }
    }
}
