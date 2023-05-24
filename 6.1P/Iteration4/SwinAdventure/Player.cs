using System;
namespace SwinAdventure
{
	public class Player : GameObject, IHaveInventory
	{
		// Field
		private Inventory _inventory;
		public Player(string name, string desc) : base(new string[] { "me","inventory"}, name,desc)
		{
			_inventory = new Inventory();
		}

		// Locate method( IDs and item_)
		public GameObject Locate(string id)
		{
			if (AreYou(id))
				return this;
			return _inventory.Fetch(id);
		}
        // Fulldescription

        public override string FullDescription
        {
            get
            {
                return $"You are {Name}, {base.FullDescription}.\nYou are carrying:\n" + _inventory.ItemList;
            }
        }
        // Property
        public Inventory Inventory
		{
			get
			{
				return _inventory;
			}
		}
    }
}

