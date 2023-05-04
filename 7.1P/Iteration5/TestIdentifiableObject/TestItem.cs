/*
* File: NunitTemplate.cs
* Unit: COS20007 Object Oriented Programming
* Institution: Swinburne University of Technology
*/
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

namespace NUnitTesting
{
    [TestFixture]
    public class TestItem
	{
		Item Infinity_Sword;

		[SetUp]
		
		public void SetUp()
		{
			Infinity_Sword = new Item(new string[] { "Sword" }, "Infinity Sword", "Infinity Sword - Powerfull Sword with flame power in every critical strike");

		}
		[Test]
		public void TestItemIdentifiable()
		{
			Assert.IsTrue(Infinity_Sword.AreYou("Sword"), "True");
			Assert.IsFalse(Infinity_Sword.AreYou("Plate"),"True");
		}
		[Test]
		public void TestShortDescription()
		{
			string _expected = "a Infinity Sword(sword)";
			string _actual = Infinity_Sword.ShortDescription;

			Assert.AreEqual(_expected, _actual);

        }
		[Test]
		public void TestFullDescription()
		{
			string _expect = "Infinity Sword - Powerfull Sword with flame power in every critical strike";
			string _actual = Infinity_Sword.FullDescription;

			Assert.AreEqual(_expect, _actual);

        }

	}
}

