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
            Assert.IsTrue(inventory.HasItem("Sword"), "True");
		}
        [Test]
        public void TestNoItem()
        {
            Assert.IsFalse(inventory.HasItem("Portion"), "True");
        }
        [Test]
        public void TestFecthItem()
        {
            Item fetchSword = inventory.Fetch("Sword");

            Assert.IsNotNull(fetchSword);
            Assert.AreEqual(Infinity_Sword, fetchSword);
            Assert.IsTrue(inventory.HasItem("Sword"), "True");
            Assert.IsTrue(inventory.HasItem("Plate"), "True");
        }
        [Test]
        public void TestTakeItem()
        {
            inventory.Take("Sword");

            Assert.IsFalse(inventory.HasItem("Sword"), "True");
            Assert.IsTrue(inventory.HasItem("Plate"), "True");
            Assert.IsFalse(inventory.HasItem("Portion"), "True");

        }
        [Test]
        public void TestItemList()
        {
            Assert.AreEqual("a Infinity sword\na Deathman plate\n", inventory.ItemList);
        }
	}
}

