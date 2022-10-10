using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CaseStudyIteration1
{
    [TestFixture]
    public class TestInventoryUnit
    {
        Item item = new Item(new string[] { "sword" }, "Wooden Sword", "Sword made out of plain old wood.");
        Item item2 = new Item(new string[] { "sword2" }, "Iron Sword", "Sword made out of strong Iron.");
        Inventory i = new Inventory();

        [Test]
        public void TestFindItem()
        {
            
            i.Put(item);
            Assert.IsTrue(i.HasItem("sword"));
        }

        [Test]
        public void TestFindNoItem()
        {
            Assert.IsFalse(i.HasItem("flower"));
        }

        [Test]
        public void TestFetchItem()
        {
            i.Put(item);
            Assert.AreEqual(item, i.Fetch("sword"));
        }

        [Test]
        public void TestTakeItem()
        {
            i = new Inventory();
            i.Put(item2);
            i.Take("sword2");
            Assert.IsFalse(i.HasItem("sword2"));
        }

        [Test]
        public void TestItemList()
        {
            i = new Inventory();

            i.Put(item);
            i.Put(item2);

            string expected = "\tWooden Sword (sword)\n\tIron Sword (sword2)\n";

            Assert.AreEqual(expected, i.ItemList);
        }
    }
}
