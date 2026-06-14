// CrazeVerse Step 5 compile-safe skeleton.
using UnityEngine;

namespace CrazeVerse.Core
{
    public class AudioManager : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public void Init()
        {
            // TODO: Add audio setup in a later step.
            IsReady = true;
        }
    }
}
