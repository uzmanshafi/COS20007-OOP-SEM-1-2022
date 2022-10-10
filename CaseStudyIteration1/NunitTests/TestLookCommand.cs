using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CaseStudyIteration1
{
    [TestFixture]
    public class TestLookCommand
    {
        private LookCommand _look;
        private Player _player;
        private Bag _bag;
        private Item _gem;

        [SetUp]
        public void Setup() 
        {
            _look = new LookCommand();
            _player = new Player("James", "of Thrones");
            _bag = new Bag(new string[] {"small", "cloth", "bag"}, "bag", "a small cloth bag");
            _gem = new Item(new string[] { "gem" }, "diamond", "a big diamond");
        }

        [Test]
        public void TestLookAtMe() 
        {
            _player.Inventory.Put(_gem);
            Assert.AreEqual("You are James of Thrones\nYou are carrying:\n\tdiamond (gem)\n", _look.Execute(_player, new string[] { "look", "at", "inventory" }));
        }

        [Test]
        public void TestLookAtGem()
        {
            _player.Inventory.Put(_gem);
            Assert.AreEqual("a big diamond", _look.Execute(_player, new[] {"look", "at", "gem"}));
        }

        [Test]
        public void TestLookAtUnk()
        {
            Assert.AreEqual("Could not find gem.", _look.Execute(_player, new[] { "look", "at", "gem" }));
        }

        [Test]
        public void TestLookAtGemInMe()
        {
            _player.Inventory.Put(_gem);
            Assert.AreEqual("a big diamond", _look.Execute(_player, new[] {"look", "at", "gem", "in", "inventory"}));
        }

        [Test]
        public void TestLookAtGemInBag()
        {
            
            _bag.Inventory.Put(_gem);
            _player.Inventory.Put(_bag);

            Assert.AreEqual("a big diamond", _look.Execute(_player, new[] { "look", "at", "gem", "in", "bag" }));
        }

        [Test]
        public void TestLookAtGemInNoBag()
        {
            _player.Inventory.Put(_gem);
            Assert.AreEqual("I cannot find the bag\n", _look.Execute(_player, new[] {"look","at","gem", "in", "bag"}));
        }

        [Test]
        public void TestLookAtNoGemInBag()
        {
            _player.Inventory.Put(_bag);
            Assert.AreEqual("Could not find gem.", _look.Execute(_player, new[] {"look","at","gem","in","bag" }));
        }

        [Test]
        public void TestInvalidLook()
        {
            Assert.AreEqual("I don't know how to look like that\n", _look.Execute(_player, new[] {"look","around","in", "inventory"}));
        }


    }
}
