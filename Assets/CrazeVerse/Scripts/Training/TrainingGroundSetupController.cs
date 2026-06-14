using UnityEngine;
using CrazeVerse.Player;
using CrazeVerse.Combat;

namespace CrazeVerse.Training
{
    public class TrainingGroundSetupController : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public TrainingSessionConfig Config { get; private set; }
        public TrainingRuntimeState RuntimeState { get; private set; }
        public TrainingObjectiveData[] Objectives { get; private set; }
        public TrainingHUDData HUDData { get; private set; }
        public TrainingStationRegistry StationRegistry;
        public TrainingPlayerSpawnPlanner SpawnPlanner;
        public TrainingLoadoutPlanner LoadoutPlanner;
        public LocalPlayerController LocalPlayer;
        public WeaponController WeaponController;
        public HealthController HealthController;
        public InventoryController InventoryController;

        public void Init()
        {
            Config = TrainingSessionConfig.CreateDefault();
            RuntimeState = TrainingRuntimeState.CreateDefault();
            Objectives = TrainingObjectiveData.CreateDefaultObjectives();
            HUDData = TrainingHUDData.CreateDefault();

            if (StationRegistry != null) StationRegistry.Init();
            if (SpawnPlanner != null) SpawnPlanner.Init();
            if (LoadoutPlanner != null) LoadoutPlanner.Init();
            if (LocalPlayer != null) LocalPlayer.Init();
            if (WeaponController != null) WeaponController.Init();
            if (HealthController != null) HealthController.Init();
            if (InventoryController != null) InventoryController.Init();

            RuntimeState.isReady = true;
            RuntimeState.totalObjectives = Objectives != null ? Objectives.Length : 0;
            RuntimeState.statusMessage = "Training setup ready";
            IsReady = true;
        }

        public void SelectStation(string stationId)
        {
            EnsureReady();

            if (string.IsNullOrEmpty(stationId))
            {
                return;
            }

            Config.selectedStationId = stationId;
            RuntimeState.selectedStationId = stationId;
            RuntimeState.statusMessage = "Selected training station: " + stationId;
            HUDData.objectiveText = "Preview station: " + stationId;
        }

        public void StartTrainingPreview()
        {
            EnsureReady();
            RuntimeState.isSessionActive = true;
            RuntimeState.statusMessage = "Training preview active";
            HUDData.statusText = "Preview active";
            // TODO: Later approved steps can load a scene and connect real player setup.
        }

        public void StopTrainingPreview()
        {
            EnsureReady();
            RuntimeState.isSessionActive = false;
            RuntimeState.statusMessage = "Training preview stopped";
            HUDData.statusText = "Preview stopped";
        }

        public void MarkObjectivePreviewComplete(string objectiveId)
        {
            EnsureReady();

            if (Objectives == null || string.IsNullOrEmpty(objectiveId))
            {
                return;
            }

            foreach (TrainingObjectiveData objective in Objectives)
            {
                if (objective != null && objective.objectiveId == objectiveId && !objective.isCompleted)
                {
                    objective.isCompleted = true;
                    RuntimeState.completedObjectives++;
                    RuntimeState.statusMessage = "Preview objective complete: " + objective.objectiveName;
                    return;
                }
            }
        }

        public void RefreshTrainingSetup()
        {
            EnsureReady();
            if (StationRegistry != null) StationRegistry.RefreshStations();
            if (LoadoutPlanner != null) LoadoutPlanner.RefreshLoadout();
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
