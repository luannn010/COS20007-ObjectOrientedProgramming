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
    public class TestPlayer
    {
        Player player;
        Item Infinity_Sword;
        Item Deathman_Plate;

        [SetUp]
        public void Setup()
        {
            player = new Player("Luan", "The berserker");
            Infinity_Sword = new Item(new string[] { "Sword" }, "Infinity Sword", "Infinity Sword - Powerfull Sword with flame power in every critical strike");
            Deathman_Plate = new Item(new string[] { "Plate" }, "Deathman Plate", "Deathman Plate - Brave like a Captian never surrender");
            player.Inventory.Put(Infinity_Sword);
        }
        //[Test]
        //public void TestPlayerLocateItem()
        //{
        //    Assert.AreEqual()
        //}

        [Test]
        public void TestIsIdentifiable()
        {
            Assert.IsTrue(player.AreYou("me"), "True");
            Assert.IsTrue(player.AreYou("inventory"), "True");
        }

        [Test]
        public void TestPlayerLocatesItself()
        {
            Assert.AreEqual(player, player.Locate("me"));
            Assert.AreEqual(player, player.Locate("inventory"));
        }

        [Test]
        public void TestPlayerLocateNothing()
        {
            Assert.AreEqual(null, player.Locate("plate"));
        }

        [Test]
        public void TestFullDescription()
        {
            Assert.AreEqual("You are Luan, The berserker. You are carrying:\n\ta Infinity Sword (sword)\n", player.FullDescription);
        }
    }
}

