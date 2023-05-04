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
            Assert.IsFalse(Infinity_Sword.AreYou("Plate"), "True");
        }

        [Test]
        public void TestShortDescription()
        {
            Assert.AreEqual("a Infinity Sword (sword)", Infinity_Sword.ShortDescription);
        }

        [Test]
        public void TestFullDescription()
        {
            Assert.AreEqual("Infinity Sword - Powerfull Sword with flame power in every critical strike", Infinity_Sword.FullDescription);

        }

    }
}

