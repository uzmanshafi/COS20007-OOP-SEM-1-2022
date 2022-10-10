/*
 * File: NunitTemplate.cs
 * Author: Joshua Wright
 * Date: 16/08/2019
 * Unit: COS20007 Object Oriented Programming
 * Institution: Swinburne University of Technology
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; //Don't forget this.

namespace CaseStudyIteration1 //Rename this to the namespace of your project.
{
    [TestFixture]
    public class UnitTest
    {
        IdentifiableObject id = new IdentifiableObject(new string[] { "fred", "bob" });

        [Test]
        public void TestAreYou()
        {
           
            Assert.IsTrue(id.AreYou("fred"));
            Assert.IsTrue(id.AreYou("bob"));

        }

        [Test]
        public void TestNotAreYou()
        {
            //Assert.IsFalse(id.AreYou("wilma")); returns false due to TestAddID method
            Assert.IsFalse(id.AreYou("bobby"));
        }

        [Test]
        public void TestCaseAreYou()
        {
            Assert.IsTrue(id.AreYou("FRED"));
            Assert.IsTrue(id.AreYou("bOB"));
        }

        [Test]
        public void TestFirstID()
        {
            Assert.AreEqual(id.FirstId, "fred");
            
        }

        [Test]
        public void TestAddId()
        {
            id.AddIdentifier("wilma");
            Assert.IsTrue(id.AreYou("wilma"));
        }

    }
}