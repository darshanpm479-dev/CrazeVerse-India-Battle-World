// CrazeVerse Step 5 compile-safe skeleton.
using UnityEngine;

namespace CrazeVerse.Core
{
    public class SaveManager : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public void Init()
        {
            // TODO: Add local save coordination in a later step.
            IsReady = true;
        }
    }
}
