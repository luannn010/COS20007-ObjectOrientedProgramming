using System;
using System.ComponentModel;
using System.Linq;

namespace NUnitTesting
{
	[TestFixture]
	public class TestLookCommand
	{
		LookCommand look;
		Player player;
		Bag bag;
		Item Infinity_Sword;
		Item Deathman_Plate;
		Item Hp_Portion;

		[SetUp]
		public void SetUp()
		{

			look = new LookCommand();
			player = new Player("Luan", "the berserker");
			bag = new Bag(new string[] { "bag" }, "Golden Bag", "Storing items with 2000 slots");
			Infinity_Sword = new Item(new string[] { "Sword" }, "Infinity Sword", "Infinity Sword - Powerfull Sword with flame power in every critical strike");
			Deathman_Plate = new Item(new string[] { "Plate" }, "Deathman Plate", "Deathman Plate - Brave like a Captian never surrender");
			Hp_Portion = new Item(new string[] { "Portion" }, "Hp Portion", "Hp Portion - Sweet drink can heal you 150 hp in 20 sec");
		}

		[Test]
		public void TestLookAtMe()
		{
			Assert.AreEqual(player.FullDescription,look.Execute(player, new string[3] { "look", "at", "me" }));
		}

		[Test]
		public void TestLookAtsword()
		{
			player.Inventory.Put(Infinity_Sword);
			Assert.AreEqual(Infinity_Sword.FullDescription, look.Execute(player, new string[] { "look", "at", "sword"}));
		}

        [Test]
        public void TestLookAtUnk()
        {
            Assert.AreEqual($"I can't find the plate", look.Execute(player, new string[] { "look", "at", "plate" }));
        }

		[Test]
		public void TestLookAtSwordInMe()
		{
			player.Inventory.Put(Infinity_Sword);
			Assert.AreEqual(Infinity_Sword.FullDescription, look.Execute(player, new string[] { "look", "at", "sword", "in", "me" }));
		}
		[Test]
		public void TestLookAtSwordInBag()
		{
			bag.Inventory.Put(Infinity_Sword);
			bag.Inventory.Put(Deathman_Plate);
			player.Inventory.Put(bag);
			Assert.AreEqual(Infinity_Sword.FullDescription, look.Execute(player, new string[] { "look", "at", "sword", "in", "bag" }) );
		}

		[Test]
		public void TestLookAtSwordInNoBag()
		{
			bag.Inventory.Put(Hp_Portion);
			Assert.AreEqual("I can't find the bag", look.Execute(player, new string[] { "look", "at", "portion", "in", "bag" }));
		}

		[Test]
		public void TestLookAtNoPlateInBag()
		{
            bag.Inventory.Put(Infinity_Sword);
            player.Inventory.Put(bag);
            Assert.AreEqual("I can't find the plate in Golden Bag", look.Execute(player, new string[] { "look", "at", "plate", "in", "bag" }));

        }
		[Test]
		public void TestInvalidLookCommand()
		{
			Assert.AreEqual("I don't know how to look like that", look.Execute(player, new string[] { "hello", "world" }));
            Assert.AreEqual("Error in look input", look.Execute(player, new string[] { "search", "for"," b" }));
            Assert.AreEqual("What do you want to look in?", look.Execute(player, new string[] { "look", "at", "plate", "on", "bag" }));
            Assert.AreEqual("What do you want to look at?", look.Execute(player, new string[] { "look", "for", "plate" }));


        }

    }


}
