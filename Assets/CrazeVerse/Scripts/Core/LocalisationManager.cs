// CrazeVerse Step 5 compile-safe skeleton.
using UnityEngine;

namespace CrazeVerse.Core
{
    public class LocalisationManager : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public void Init()
        {
            // TODO: Add language key setup in a later step.
            IsReady = true;
        }
    }
}
