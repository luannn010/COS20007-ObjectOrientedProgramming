/*
* File: TestCounter.cs
* Unit: COS20007 Object Oriented Programming
* Institution: Swinburne University of Technology
*/
using NUnit.Framework;
using System;
using ClockTask;
namespace NUnitTesting
{


    [TestFixture]
    public class TestCounter
    {
        private Counter testCounter;
        [SetUp]
        public void SetUp()
        {
            testCounter = new Counter("testCounter");
        }
        [Test]
        public void TestCounterStartAt0()
        {

            Assert.AreEqual(0, testCounter.Ticks);
        }
        [Test]
        public void TestCounterIncreaseBy1()
        {

          

            testCounter.Increment();

            Assert.AreEqual(1, testCounter.Ticks);
        }
        [Test]
        public void TestCounterIncrement()
        {

            
            for (int i = 0; i < 3; i++)
            {
                testCounter.Increment();
            }
            Assert.AreEqual(3, testCounter.Ticks);
        }
        [Test]
        public void TestCounterReset()
        {
            
            for (int i = 0; i < 3; i++)
            {
                testCounter.Increment();
            }
            

            testCounter.Reset();
            Assert.AreEqual(0, testCounter.Ticks);
        }
    }
}