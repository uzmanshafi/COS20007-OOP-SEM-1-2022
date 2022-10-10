using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; //Don't forget this.

namespace CaseStudyIteration1
{
    [TestFixture]
    public class TestItemUnit
    {

        Item i = new Item(new string[] { "sword" } , "Wooden Sword" , "Sword made out of plain old wood.");

        [Test]
        public void TestItemID()
        {
            Assert.True(i.AreYou("sword"));
        }

        [Test]
        public void TestShortDesc()
        {
            Assert.AreEqual("Wooden Sword (sword)", i.ShortDescription);
        }

        [Test]
        public void TestFullDesc()
        {
            Assert.AreEqual("Sword made out of plain old wood.", i.FullDescription);
        }

    }
}
