using UnityEngine;

namespace CrazeVerse.Training
{
    public class TrainingStationRegistry : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public TrainingStationData[] Stations { get; private set; }

        public void Init()
        {
            Stations = TrainingStationData.CreateDefaultStations();
            IsReady = true;
        }

        public TrainingStationData GetStationById(string stationId)
        {
            EnsureReady();

            if (Stations == null || string.IsNullOrEmpty(stationId))
            {
                return null;
            }

            foreach (TrainingStationData station in Stations)
            {
                if (station != null && station.stationId == stationId)
                {
                    return station;
                }
            }

            return null;
        }

        public TrainingStationData[] GetAllStations()
        {
            EnsureReady();
            return Stations;
        }

        public void RefreshStations()
        {
            EnsureReady();
            // TODO: Later approved steps can bind stations to UI cards or scene markers.
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
