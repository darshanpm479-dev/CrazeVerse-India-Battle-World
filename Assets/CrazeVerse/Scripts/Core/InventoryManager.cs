// CrazeVerse Step 11 inventory manager bridge. Local skeleton only.
using UnityEngine;
using CrazeVerse.Combat;

namespace CrazeVerse.Core
{
    public class InventoryManager : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public InventoryController InventoryController;

        public void Init()
        {
            if (InventoryController != null)
            {
                InventoryController.Init();
            }

            // TODO: Later approved steps can connect this manager to saved local inventory data.
            IsReady = true;
        }
    }
}
