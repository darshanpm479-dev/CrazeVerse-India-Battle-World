using UnityEngine;

namespace CrazeVerse.Modes
{
    public class TrainingGroundEntryController : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public TrainingOptionData[] Options { get; private set; }
        public TrainingOptionData SelectedOption { get; private set; }
        public string StatusMessage { get; private set; }

        public void Init()
        {
            Options = TrainingOptionData.CreateDefaultOptions();
            SelectedOption = Options != null && Options.Length > 0 ? Options[0] : null;
            StatusMessage = "Training preview ready";
            IsReady = true;
        }

        public void SelectOption(string optionName)
        {
            EnsureReady();

            if (Options == null || string.IsNullOrEmpty(optionName))
            {
                return;
            }

            foreach (TrainingOptionData option in Options)
            {
                if (option != null && option.optionName == optionName)
                {
                    SelectedOption = option;
                    StatusMessage = option.isUnlocked ? "Selected: " + option.optionName : "Locked";
                    return;
                }
            }
        }

        public void EnterTrainingPreview()
        {
            EnsureReady();
            StatusMessage = SelectedOption != null
                ? "Preview only: " + SelectedOption.optionName
                : "Preview only";
            // TODO: Connect to real training scene entry in a later approved step.
        }

        public void RefreshTrainingGround()
        {
            EnsureReady();
            // TODO: Bind local training options to UI cards when Unity Canvas is created later.
        }

        private void EnsureReady()
        {
            if (!IsReady)
            {
                Init();
            }
        }
    }
}
