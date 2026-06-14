using UnityEngine;

namespace CrazeVerse.Player
{
    public class ThirdPersonCameraRig : MonoBehaviour
    {
        public Transform FollowTarget;
        public Vector3 FollowOffset;
        public bool IsReady { get; private set; }

        public void Init()
        {
            if (FollowOffset == Vector3.zero)
            {
                FollowOffset = new Vector3(0f, 3f, -6f);
            }

            IsReady = true;
        }

        public void SetFollowTarget(Transform target)
        {
            FollowTarget = target;
        }

        public void RefreshCameraRig()
        {
            if (!IsReady)
            {
                Init();
            }

            // TODO: Add camera follow and smoothing in a later approved step.
        }
    }
}
