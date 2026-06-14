using UnityEngine;

namespace CrazeVerse.Core
{
    public class GameManager : MonoBehaviour
    {
        public bool IsReady { get; private set; }

        public void Init()
        {
            // TODO: Connect core manager startup order in a later step.
            IsReady = true;
        }
    }
}
