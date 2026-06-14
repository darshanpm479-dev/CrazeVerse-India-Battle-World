using UnityEngine;

namespace CrazeVerse.Player
{
    public class PlayerSpawnPoint : MonoBehaviour
    {
        public string spawnId;
        public string spawnLabel;

        public Vector3 GetSpawnPosition()
        {
            return transform.position;
        }

        public Quaternion GetSpawnRotation()
        {
            return transform.rotation;
        }
    }
}
