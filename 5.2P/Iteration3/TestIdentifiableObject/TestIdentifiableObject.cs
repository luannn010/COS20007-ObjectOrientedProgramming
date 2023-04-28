
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
    public class TestIdentifiableObject
    {
        private Identifiable_Object id;
        [SetUp]
        public void SetUp()
        {
            id = new Identifiable_Object(new string[] { "fred", "bob" });
        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(id.AreYou("fred"), "True");
            Assert.IsTrue(id.AreYou("bob"), "True");

        }
        [Test]
        public void TestNotAreYou()
        {


            Assert.IsFalse(id.AreYou("wilma"), "False");
        }
        [Test]
        public void TestCaseSensitive()
        {
            
            Assert.IsTrue(id.AreYou("FRED"), "True");
            Assert.IsTrue(id.AreYou("bOB"), "True");
        }
        [Test]
        public void TestFirstID()
        {
            Assert.AreEqual("fred", id.FirstID);

        }
        [Test]
        public void TestNoID()
        {
            id = new Identifiable_Object(new string[] { });
            Assert.AreEqual("", id.FirstID);
        }
        [Test]
        public void TestAddID()
        {

            id.AddIdentifier("wilma");

            
            Assert.IsTrue(id.AreYou("wilma"), "True");
            Assert.IsTrue(id.AreYou("fred"), "True");
            Assert.IsTrue(id.AreYou("bob"), "True");

        }

    }

}