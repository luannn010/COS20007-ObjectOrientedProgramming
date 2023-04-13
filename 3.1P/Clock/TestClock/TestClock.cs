/*
* File: TestClock.cs
* Unit: COS20007 Object Oriented Programming
* Institution: Swinburne University of Technology
* Author: LuanNguyen
*/
using System;
using ClockTask;
using NUnit.Framework;

namespace NUnitTesting
{
    [TestFixture]
    public class TestClock
    {
        private Clock testClock;
        [SetUp]
        public void SetUp()
        {
            testClock = new Clock();
        }
        [Test]

        public void TestClockFormat()
        {
            
            Assert.AreEqual("00:00:00", testClock.Time);
        }
        [Test]
        public void TestClockReset()
        {
            //Test increase 20mins
            for (int i = 0; i < 120; i++)
            {
                testClock.Tick();
            }
            //Clock Reset
            testClock.Reset();
            Assert.AreEqual("00:00:00", testClock.Time);
        }
        [Test]
        public void TestClockIncrement()
        {
            //Test 10mins
            for (int i = 0; i < 600; i++)
            {
                testClock.Tick();
            }

            Assert.AreEqual("00:10:00", testClock.Time);
        }
    }
}
