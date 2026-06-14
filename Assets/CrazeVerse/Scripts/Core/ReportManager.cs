// CrazeVerse Step 5 compile-safe skeleton.
using UnityEngine;

namespace CrazeVerse.Core
{
    public class ReportManager : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public void Init()
        {
            // TODO: Add player report routing in a later step.
            IsReady = true;
        }
    }
}
