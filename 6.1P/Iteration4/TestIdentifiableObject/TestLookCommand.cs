using System;
using System.ComponentModel;
using System.Linq;

namespace NUnitTesting
{
	[TestFixture]
	public class TestLookCommand
	{
		Command look;
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
			Assert.AreEqual(look.Execute(player, new string[3] { "look", "at", "me" }),$"{player.FullDescription}");
		}

		[Test]
		public void TestLookAtsword()
		{
			player.Inventory.Put(Infinity_Sword);
			Assert.AreEqual(look.Execute(player, new string[] { "look", "at", "sword"}),$"{Infinity_Sword.FullDescription }");
		}

        [Test]
        public void TestLookAtUnk()
        {
            Assert.AreEqual(look.Execute(player, new string[] { "look", "at", "plate" }), $"I can\'t find the plate");
        }

		[Test]
		public void TestLookAtSwordInMe()
		{
			player.Inventory.Put(Infinity_Sword);
			Assert.AreEqual(look.Execute(player, new string[] { "look", "at", "sword", "in", "me" }), $"{Infinity_Sword.FullDescription}");
		}
		[Test]
		public void TestLookAtSwordInBag()
		{
			bag.Inventory.Put(Infinity_Sword);
			bag.Inventory.Put(Deathman_Plate);
			player.Inventory.Put(bag);
			Assert.AreEqual(look.Execute(player, new string[] { "look", "at", "sword", "in", "bag" }), $"{Infinity_Sword.FullDescription}");
		}

		[Test]
		public void TestLookAtSwordInNoBag()
		{
			bag.Inventory.Put(Hp_Portion);
			Assert.AreEqual(look.Execute(player, new string[] { "look", "at", "portion", "in", "bag" }), $"I can\'t find the bag");
		}

		[Test]
		public void TestLookAtNoPlateInBag()
		{
            bag.Inventory.Put(Infinity_Sword);
            player.Inventory.Put(bag);
            Assert.AreEqual(look.Execute(player, new string[] { "look", "at", "plate", "in", "bag" }), $"I can\'t find the plate in Golden Bag");

        }
		[Test]
		public void TestInvalidLookCommand()
		{
			Assert.AreEqual(look.Execute(player, new string[] { "hello world" }), "Error in look input");
		}
    }
}
