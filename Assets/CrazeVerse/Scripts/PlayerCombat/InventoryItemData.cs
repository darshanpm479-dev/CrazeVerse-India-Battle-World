namespace CrazeVerse.Combat
{
    [System.Serializable]
    public class InventoryItemData
    {
        public string itemId;
        public string itemName;
        public InventoryItemType itemType;
        public int quantity;
        public int maxStack;
        public bool isEquipped;

        public static InventoryItemData Create(string itemId, string itemName, InventoryItemType itemType, int quantity)
        {
            return new InventoryItemData
            {
                itemId = string.IsNullOrWhiteSpace(itemId) ? "ITEM_LOCAL" : itemId,
                itemName = string.IsNullOrWhiteSpace(itemName) ? "Local Item" : itemName,
                itemType = itemType,
                quantity = quantity < 0 ? 0 : quantity,
                maxStack = 99,
                isEquipped = false
            };
        }
    }
}
