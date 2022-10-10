using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CaseStudyIteration1
{
    [TestFixture]
    public class TestBag
    {

        Bag _bag = new Bag(new string[] {"small", "leather", "bag"}, "bag", "A small leather bag");
        Item woodSword = new Item(new string[] { "sword" }, "Wooden Sword", "Sword made out of plain old wood.");
        Item ironSword = new Item(new string[] { "sword1" }, "Iron Sword", "Sword made out of iron.");
        Item goldSword = new Item(new string[] { "sword2" }, "Golden Sword", "Sword made out of gold.");
        Item diamondSword = new Item(new string[] { "sword3" }, "Diamond Sword", "Sword made out of diamond.");

        [Test]
        public void TestBagLocateItem()
        {
            _bag.Inventory.Put(woodSword);
            _bag.Inventory.Put(ironSword);
            _bag.Inventory.Put(goldSword);
            _bag.Inventory.Put(diamondSword);

            Assert.AreSame(woodSword, _bag.Locate("sword"));
            Assert.AreSame(ironSword, _bag.Locate("sword1"));
            Assert.AreSame(goldSword, _bag.Locate("sword2"));
            Assert.AreSame(diamondSword, _bag.Locate("sword3"));
        }

        [Test]
        public void TestBagLocation()
        {
            Assert.AreSame(_bag, _bag.Locate("bag"));
        }

        [Test]
        public void TestBagLocatesNothing()
        {
            Assert.AreSame(null, _bag.Locate("portion"));
        }

        [Test]
        public void TestBagFullDesc()
        {
            Assert.AreEqual($"In The {_bag.Name} , player has : \n\t", _bag.FullDescription);
        }

        [Test]
        public void TestBaginBag()
        {
            Bag b1 = new Bag(new string[] { "big", "leather", "bag1" }, "bag", "A big leather bag");
            Bag b2 = new Bag(new string[] { "small", "plastic", "bag2" }, "bag", "A small plastic bag");

            b1.Inventory.Put(b2);
            b1.Inventory.Put(woodSword);
            b2.Inventory.Put(ironSword);

            Assert.AreSame(b2, b1.Locate("plastic"));
            Assert.AreSame(woodSword, b1.Locate("sword"));
            Assert.AreEqual(null, b1.Locate("sword1"));
        }
    }
}
