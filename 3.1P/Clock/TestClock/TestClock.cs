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
            //Test increase 1 hour, 1min, 1 sec
            for (int i = 0; i < 3661; i++)
            {
                testClock.Tick();
            }
            //Check that the time is "01:01:01" before resetting
            Assert.AreEqual("01:01:01", testClock.Time);
            //Clock Reset
            testClock.Reset();
            Assert.AreEqual("00:00:00", testClock.Time);
        }
        [Test]
        public void TestClock1Sec()
        {
            testClock.Tick();
            Assert.AreEqual("00:00:01", testClock.Time);
            
        }
        [Test]
        public void TestClock1Min()
        {
            //Test 00:00:59
            for (int i = 0; i<59; i++)
            {
                testClock.Tick();
            }
            Assert.AreEqual("00:00:59", testClock.Time);
            testClock.Tick();
            Assert.AreEqual("00:01:00",testClock.Time);
        }
        [Test]
        public void TestClockTick1Hour()
        {
            //Test 00:59:59
            for (int i = 0; i < 3599; i++)
            {
                testClock.Tick();
            }

            Assert.AreEqual("00:59:59", testClock.Time);
            testClock.Tick();
            Assert.AreEqual("01:00:00", testClock.Time);
        }
        [Test]
        public void TestClockOneDay()
        { 
            for (int i = 0; i < 86399; i++)
            {
                testClock.Tick();
            }
            Assert.AreEqual("23:59:59", testClock.Time);
            testClock.Tick();
            Assert.AreEqual("00:00:00", testClock.Time);
        }

        [Test]
        public void TestClockContinuesToTickAfterMaximumLimit()
        {
            // Test that the clock continues to tick after it reaches the maximum time limit of 23:59:59
            for (int i = 0; i < 86400; i++)
            {
                testClock.Tick();
            }
            Assert.AreEqual("00:00:00", testClock.Time);
        }

    }
}
