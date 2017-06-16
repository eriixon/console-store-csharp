using System.Collections.Generic;

namespace BCW.ConsoleStore.Front
{
    public class Inventory
    {
        public List<IItem> InventoryItems = new List<IItem>();
        public void AddIntentory (IItem item)
        {
            InventoryItems.Add(item);
        }
        public void RemoveInventory(IItem item)
        {
            InventoryItems.Remove(item);
        }
        public void ViewInventory()
        {
            DisplayItems.Display(InventoryItems, "Inventory");
        }
    }
}