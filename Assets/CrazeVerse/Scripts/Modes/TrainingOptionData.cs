namespace CrazeVerse.Modes
{
    [System.Serializable]
    public class TrainingOptionData
    {
        public string optionName;
        public string description;
        public bool isUnlocked;
        public string difficulty;

        public static TrainingOptionData[] CreateDefaultOptions()
        {
            return new[]
            {
                new TrainingOptionData { optionName = "Movement Practice", description = "Practice basic movement later.", isUnlocked = true, difficulty = "Easy" },
                new TrainingOptionData { optionName = "Aim Practice", description = "Practice camera and aim flow later.", isUnlocked = true, difficulty = "Easy" },
                new TrainingOptionData { optionName = "Weapon Practice", description = "Practice equipment flow later.", isUnlocked = true, difficulty = "Medium" },
                new TrainingOptionData { optionName = "Ghost Scanner Practice", description = "Practice scanner tutorial flow later.", isUnlocked = true, difficulty = "Medium" },
                new TrainingOptionData { optionName = "Zombie Wave Practice", description = "Practice wave tutorial flow later.", isUnlocked = true, difficulty = "Medium" },
                new TrainingOptionData { optionName = "Vehicle Practice", description = "Practice vehicle entry flow later.", isUnlocked = true, difficulty = "Medium" },
                new TrainingOptionData { optionName = "Squad Bot Practice", description = "Practice team command flow later.", isUnlocked = true, difficulty = "Easy" }
            };
        }
    }
}
