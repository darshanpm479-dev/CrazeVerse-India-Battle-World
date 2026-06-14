// CrazeVerse Step 5 compile-safe skeleton.
using UnityEngine;

namespace CrazeVerse.Core
{
    public class SceneLoader : MonoBehaviour
    {
        public bool IsReady { get; private set; }

        public void Init()
        {
            // TODO: Add safe scene loading flow in a later step.
            IsReady = true;
        }
    }
}
