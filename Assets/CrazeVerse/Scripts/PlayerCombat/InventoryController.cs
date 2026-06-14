using UnityEngine;

namespace CrazeVerse.Combat
{
    public class InventoryController : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public InventoryData Inventory { get; private set; }

        public void Init()
        {
            Inventory = InventoryData.CreateDefault();
            IsReady = true;
        }

        public bool AddItem(InventoryItemData item)
        {
            EnsureReady();

            if (item == null || !Inventory.HasSpace())
            {
                return false;
            }

            int usedSlots = Inventory.GetUsedSlots();
            InventoryItemData[] updatedItems = new InventoryItemData[usedSlots + 1];

            for (int i = 0; i < usedSlots; i++)
            {
                updatedItems[i] = Inventory.items[i];
            }

            updatedItems[usedSlots] = item;
            Inventory.items = updatedItems;
            return true;
        }

        public bool RemoveItem(string itemId, int quantity)
        {
            EnsureReady();

            if (Inventory.items == null || string.IsNullOrWhiteSpace(itemId) || quantity <= 0)
            {
                return false;
            }

            for (int i = 0; i < Inventory.items.Length; i++)
            {
                InventoryItemData item = Inventory.items[i];
                if (item != null && item.itemId == itemId)
                {
                    item.quantity = Mathf.Max(0, item.quantity - quantity);
                    return true;
                }
            }

            return false;
        }

        public bool HasItem(string itemId)
        {
            EnsureReady();

            if (Inventory.items == null || string.IsNullOrWhiteSpace(itemId))
            {
                return false;
            }

            foreach (InventoryItemData item in Inventory.items)
            {
                if (item != null && item.itemId == itemId && item.quantity > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void SetCoins(int coins)
        {
            EnsureReady();
            Inventory.coins = Mathf.Max(0, coins);
        }

        public void AddCoins(int amount)
        {
            EnsureReady();
            Inventory.coins += Mathf.Max(0, amount);
        }

        public bool SpendCoins(int amount)
        {
            EnsureReady();
            int safeAmount = Mathf.Max(0, amount);

            if (Inventory.coins < safeAmount)
            {
                return false;
            }

            Inventory.coins -= safeAmount;
            return true;
        }

        public void RefreshInventory()
        {
            EnsureReady();
            // TODO: Later approved steps can connect this local data to UI.
        }

        private void EnsureReady()
        {
            if (!IsReady)
            {
                Init();
            }
        }
    }
}
