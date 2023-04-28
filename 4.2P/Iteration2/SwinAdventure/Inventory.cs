using System;
namespace SwinAdventure
{
	public class Inventory
	{
		private List<Item> _items;

		public Inventory()
		{
			_items = new List<Item>();
		}

        // Check if has Item in Inventory
		public bool HasItem(string id)
		{
			if (_items.Count == 0)
				return false;
			foreach (Item item in _items)
			{
				if (item.AreYou(id))
					return true;
			}
			return false;
		}

        // Put Item to Inventory
		public void Put(Item itm)
		{
			_items.Add(itm);
		}

        // Take Item from Inventory
        public Item Take(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    Item itemRemoval = item;
                    _items.Remove(item);
                    return itemRemoval;
                }
            }
            return null;
        }
        // SHow your item
        public Item Fetch(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    return item;
                }
            }
            return null;
        }
        //Properties
        public string ItemList
        {
            get
            {
               
                string list = "";
                foreach (Item item in _items)
                {
                    list = list + "\t" + item.ShortDescription + "\n";
                }
                return list;
            }
        }

    }
}


