using UnityEngine;

namespace CrazeVerse.Training
{
    public class TrainingPlayerSpawnPlanner : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public Vector3 DefaultSpawnPosition { get; private set; }
        public Quaternion DefaultSpawnRotation { get; private set; }

        public void Init()
        {
            DefaultSpawnPosition = Vector3.zero;
            DefaultSpawnRotation = Quaternion.identity;
            IsReady = true;
        }

        public void SetDefaultSpawn(Vector3 position, Quaternion rotation)
        {
            DefaultSpawnPosition = position;
            DefaultSpawnRotation = rotation;
        }

        public Vector3 GetSpawnPosition()
        {
            EnsureReady();
            return DefaultSpawnPosition;
        }

        public Quaternion GetSpawnRotation()
        {
            EnsureReady();
            return DefaultSpawnRotation;
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
