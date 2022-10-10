using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CaseStudyIteration1
{
    [TestFixture]
    public class TestLocation
    {
        private Location _loc;
        private Item _gem;


        [SetUp]
        public void Setup()
        {
            _gem = new Item(new string[] { "gem" }, "diamond", "a big diamond");
            _loc = new Location(new string[] { "north" }, "North City", "The North City District.");
        }

        [Test]
        public void TestIdentifyThemselves()
        {
            Assert.True(_loc.AreYou("north"));
        }

        [Test]
        public void TestLocateItemsTheyHave()
        {
            _loc.Inventory.Put(_gem);
            Assert.AreEqual(_loc.Locate("gem"), _gem);
        }

        [Test]
        public void TestPlayerLocatesItemsInTheirLocation()
        {
            Assert.AreEqual("The player is in " + _loc.Name + ": \nItems nearby : \n" + _loc.Inventory.ItemList, _loc.FullDescription);
        }
    }
}
