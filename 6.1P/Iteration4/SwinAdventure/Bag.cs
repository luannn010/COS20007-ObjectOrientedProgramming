using System;
namespace SwinAdventure
{
    public class Bag : Item,IHaveInventory
    {
        // Fields
        private Inventory _inventory;

        // Property

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

        // Constructor
        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (this.AreYou(id))
            {
                return this;
            }
            else if (_inventory.HasItem(id))
            {
                return _inventory.Fetch(id);
            }
            return null;

        }

        public string FullDescription
        {
            get
            {
                string InventoryDescription = "In the " + Name + " you can see:\n";
                InventoryDescription += _inventory.ItemList;
                return InventoryDescription;
            }
        }
    }
}

