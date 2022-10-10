using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CaseStudyIteration1
{
    [TestFixture]
    public class TestPlayerUnit
    {
        Player player = new Player("James", "of Thrones");
        Item woodSword = new Item(new string[] { "sword" }, "Wooden Sword", "Sword made out of plain old wood.");
        Item ironSword = new Item(new string[] { "sword1" }, "Iron Sword", "Sword made out of iron.");
        Item goldSword = new Item(new string[] { "sword2" }, "Golden Sword", "Sword made out of gold.");

        [SetUp]
        public void Setup()
        {
            player.Inventory.Put(woodSword);
            player.Inventory.Put(ironSword);
            player.Inventory.Put(goldSword);
        }

        [Test]
        public void TestPlayerID()
        {
            Assert.IsTrue(player.AreYou("me"));
            Assert.IsTrue(player.AreYou("inventory"));
        }

        [Test]
        public void TestPlayerLocatesItem()
        {
            

            Assert.AreSame(woodSword, player.Locate("sword"));
            Assert.AreSame(ironSword, player.Locate("sword1"));
            Assert.AreSame(goldSword, player.Locate("sword2"));
        }

        [Test]
        public void TestPlayerLocatation()
        {
            Assert.AreSame(player, player.Locate("me"));
        }

        [Test]
        public void TestPlayerLocatesNothing()
        {
            Assert.AreEqual(null, player.Locate("fail"));
        }

        [Test]
        public void TestPlayerFullDesc()
        {
            Assert.AreEqual("You are James of Thrones\nYou are carrying:\n\tWooden Sword (sword)\n\tIron Sword (sword1)\n\tGolden Sword (sword2)\n", player.FullDescription);
        }
    }
}
