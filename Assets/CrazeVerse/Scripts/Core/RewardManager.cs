// CrazeVerse Step 5 compile-safe skeleton.
using UnityEngine;

namespace CrazeVerse.Core
{
    public class RewardManager : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public void Init()
        {
            // TODO: Add local reward routing in a later step.
            IsReady = true;
        }
    }
}
