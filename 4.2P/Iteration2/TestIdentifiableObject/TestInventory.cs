/*
* File: NunitTemplate.cs
* Unit: COS20007 Object Oriented Programming
* Institution: Swinburne University of Technology
*/
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace NUnitTesting
{
    [TestFixture]
    public class TestInventory
	{
		Inventory inventory;
        Item Infinity_Sword;
        Item Deathman_Plate;
        Item Hp_Portion;

        [SetUp]
		public void SetUp()
		{
            inventory = new Inventory();
            // Items
            Infinity_Sword = new Item(new string[] { "Sword" }, "Infinity", "Infinity Sword - Powerfull Sword with flame power in every critical strike");
            Deathman_Plate = new Item(new string[] { "Plate" }, "Deathman", "Deathman Plate - Brave like a Captian never surrender");
            Hp_Portion = new Item(new string[] { "Portion" }, "Hp Portion", "Hp Portion - Sweet drink can heal you 150 hp in 20 sec");
            //Put Item to bag
            inventory.Put(Infinity_Sword);
            inventory.Put(Deathman_Plate);
        }
		[Test]
		public void TestHasItem()
		{
            Assert.IsTrue(inventory.HasItem("Sword"));
		}
        [Test]
        public void TestNoItem()
        {
            Assert.IsFalse(inventory.HasItem("Portion"));
        }
        [Test]
        public void TestFecthItem()
        {
            Assert.AreEqual(Infinity_Sword, inventory.Fetch("Sword"));
            Assert.IsTrue(inventory.HasItem("Sword"));
        }
        [Test]
        public void TestTakeItem()
        {
            Assert.AreEqual(Infinity_Sword, inventory.Take("Sword"));
            Assert.IsFalse(inventory.HasItem("Sword") );
            Assert.IsTrue(inventory.HasItem("Plate") );
            Assert.IsFalse(inventory.HasItem("Portion") );

        }
        [Test]
        public void TestItemList()
        {
            Assert.AreEqual("\ta Infinity (sword)\n\ta Deathman (plate)\n", inventory.ItemList);
        }
	}
}

