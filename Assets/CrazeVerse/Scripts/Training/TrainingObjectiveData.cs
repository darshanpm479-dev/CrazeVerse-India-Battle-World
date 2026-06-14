namespace CrazeVerse.Training
{
    [System.Serializable]
    public class TrainingObjectiveData
    {
        public string objectiveId;
        public string objectiveName;
        public string description;
        public bool isCompleted;

        public static TrainingObjectiveData Create(string objectiveId, string objectiveName, string description)
        {
            return new TrainingObjectiveData
            {
                objectiveId = objectiveId,
                objectiveName = objectiveName,
                description = description,
                isCompleted = false
            };
        }

        public static TrainingObjectiveData[] CreateDefaultObjectives()
        {
            return new[]
            {
                Create("basic_movement", "Learn basic movement", "Local preview objective."),
                Create("camera_preview", "Check camera preview", "Local preview objective."),
                Create("inventory_preview", "Open inventory preview", "Local preview objective."),
                Create("equip_preview", "Equip preview tool", "Local preview objective."),
                Create("action_preview", "Practice interaction preview", "Local preview objective.")
            };
        }
    }
}
