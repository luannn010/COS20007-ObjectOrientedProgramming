
/*
* File: NunitTemplate.cs
* Unit: COS20007 Object Oriented Programming
* Institution: Swinburne University of Technology
*/
using System;
using System.Collections.Generic;
using NUnit.Framework;
namespace TestIdentifiableObject;

[TestFixture]
public class NUnitTestIdentifiableObject
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



        //bool value1 = id.AreYou("fred");
        //bool value2 = id.AreYou("bob");

        //Assert.IsTrue(value1, "True");
        //Assert.IsTrue(value2, "True");
        // Fix remove local variables

        Assert.IsTrue(id.AreYou("fred"), "True");
        Assert.IsTrue(id.AreYou("bob"), "True");

    }
    [Test]
    public void TestNotAreYou()
    {

        //bool value1 = id.AreYou("Wilma");
        //bool value2 = id.AreYou("Boby");
        //Assert.IsFalse(value1, "False");
        //Assert.IsFalse(value2, "False");
        // Fix remove local variables
        Assert.IsTrue(id.AreYou("fred"), "False"); 
        Assert.IsTrue(id.AreYou("bob"), "False"); 
    }
    [Test]
    public void TestCaseSensitive()
    {
        //bool value1 = id.AreYou("FRED");
        //bool value2 = id.AreYou("bOB");
        //Assert.IsTrue(value1, "True");
        //Assert.IsTrue(value2, "True");
        // Fix remove local variables
        Assert.IsTrue(id.AreYou("FRED"), "True");
        Assert.IsTrue(id.AreYou("bOB"), "True");
    }
    [Test]
    public void TestFirstID()
    {
        string _expect = "fred";
        string _actual = id.FirstID;

        Assert.AreEqual(_expect, _actual);

    }
    [Test]
    public void TestNoID()
    {
        Identifiable_Object id = new Identifiable_Object(new string[] {});

        string _expect = "";
        string _actual = id.FirstID;
        Assert.AreEqual(_expect, _actual);
    }
    [Test]
    public void TestAddID()
    {

        id.AddIdentifier("wilma");

        //bool value1 = id.AreYou("wilma");
        //bool value2 = id.AreYou("fred");
        //bool value3 = id.AreYou("bob");

        //Assert.IsTrue(value1, "True");
        //Assert.IsTrue(value2, "True");
        //Assert.IsTrue(value3, "True");
        // Fix remove local variables
        Assert.IsTrue(id.AreYou("wilma"),"True");
        Assert.IsTrue(id.AreYou("fred"), "True");
        Assert.IsTrue(id.AreYou("bob"), "True");

            }

}

