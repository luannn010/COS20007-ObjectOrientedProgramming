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
    public class TestBag
    {
        Item Infinity_Sword;
        Item Deathman_Plate;
        Bag bag1;
        Bag bag2;
        [SetUp]

        public void SetUp()
            {
                Infinity_Sword = new Item(new string[] { "Sword" }, "Infinity Sword", "Infinity Sword - Powerfull Sword with flame power in every critical strike");
                Deathman_Plate = new Item(new string[] { "Plate" }, "Deathman Plate", "Deathman Plate - Brave like a Captian never surrender");
                bag1 = new Bag(new string[] { "bag1" }, "Golden Bag", "Storing items with 2000 slots");
                bag2 = new Bag(new string[] { "bag2" }, "Diamond Bag", "Storing items with 3000 slots");

            }

        [Test]
        public void TestBagLocateItems()
        {
            bag1.Inventory.Put(Infinity_Sword);
            Assert.AreEqual(Infinity_Sword, bag1.Locate("Sword") );
        }
        [Test]
        public void TestBagLocatesItself()
        {
            Assert.AreEqual(bag1, bag1.Locate("bag1") );
        }
        [Test]
        public void TestBagLocatesNothing()
        {
            Assert.AreEqual(null, bag1.Locate("Nothing") );
        }
        [Test]
        public void TestBagFullDescription()
        {
            bag1.Inventory.Put(Infinity_Sword);
            Assert.AreEqual(bag1.FullDescription, "In the Golden Bag you can see:\n\ta Infinity Sword(sword)\n");
        }
        [Test]
        public void TestBagInBag()
        {

            bag1.Inventory.Put(Infinity_Sword);
            bag2.Inventory.Put(Deathman_Plate);
            bag1.Inventory.Put(bag2);

            Assert.AreEqual(bag2, bag1.Locate("bag2") );
            Assert.AreEqual(Infinity_Sword, bag1.Locate("Sword") );
            Assert.AreEqual( null ,bag1.Locate("Plate"));


        }
    }
}
