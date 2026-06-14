namespace CrazeVerse.Combat
{
    [System.Serializable]
    public class InventoryData
    {
        public InventoryItemData[] items;
        public int maxSlots;
        public int coins;

        public static InventoryData CreateDefault()
        {
            return new InventoryData
            {
                maxSlots = 30,
                coins = 500,
                items = new[]
                {
                    InventoryItemData.Create("TOOL_SPIRIT_SCANNER", "Spirit Scanner", InventoryItemType.Tool, 1),
                    InventoryItemData.Create("SACRED_LAMP", "Sacred Lamp", InventoryItemType.SacredItem, 1),
                    InventoryItemData.Create("BASIC_MED_KIT", "Basic Med Kit", InventoryItemType.Consumable, 1)
                }
            };
        }

        public bool HasSpace()
        {
            return GetUsedSlots() < maxSlots;
        }

        public int GetUsedSlots()
        {
            return items == null ? 0 : items.Length;
        }
    }
}
