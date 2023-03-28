/*
* File: NunitTemplate.cs
* Unit: COS20007 Object Oriented Programming
* Institution: Swinburne University of Technology
*/
using NUnit.Framework;
using System;
using ClockTask;
namespace CounterTest;



[TestFixture]
public class TestClock
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

        //Increase counter by 1
        
            testCounter.Increment();
        
        Assert.AreEqual(1, testCounter.Ticks);
    }
    [Test]
    public void TestCounterIncrement()
    {

        //Increase counter by 3
        for (int i = 0; i < 3; i++)
        {
            testCounter.Increment();
        }
        Assert.AreEqual(3, testCounter.Ticks);
    }
    [Test]
    public void TestCounterReset()
    {
        //Increase counter by 3
        for (int i = 0; i < 3; i++)
        {
            testCounter.Increment();
        }
        //Reset

        testCounter.Reset();
        Assert.AreEqual(0, testCounter.Ticks);
    }
}