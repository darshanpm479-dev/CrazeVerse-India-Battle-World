using UnityEngine;

namespace CrazeVerse.Player
{
    public class PlayerCameraTarget : MonoBehaviour
    {
        public Transform TargetTransform;
        public Vector3 Offset;

        public void SetTarget(Transform target)
        {
            TargetTransform = target;
        }

        public Vector3 GetTargetPosition()
        {
            Transform safeTarget = TargetTransform != null ? TargetTransform : transform;
            return safeTarget.position + Offset;
        }
    }
}
