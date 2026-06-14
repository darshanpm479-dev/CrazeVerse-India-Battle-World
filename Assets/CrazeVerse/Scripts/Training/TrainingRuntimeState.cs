namespace CrazeVerse.Training
{
    [System.Serializable]
    public class TrainingRuntimeState
    {
        public bool isReady;
        public bool isSessionActive;
        public string selectedStationId;
        public string statusMessage;
        public int completedObjectives;
        public int totalObjectives;

        public static TrainingRuntimeState CreateDefault()
        {
            return new TrainingRuntimeState
            {
                isReady = false,
                isSessionActive = false,
                selectedStationId = "movement_basics",
                statusMessage = "Training setup ready",
                completedObjectives = 0,
                totalObjectives = 0
            };
        }
    }
}
