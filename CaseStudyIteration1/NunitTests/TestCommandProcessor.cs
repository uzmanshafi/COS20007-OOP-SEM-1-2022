using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CaseStudyIteration1
{
    [TestFixture]
    public class TestCommandProcessor
    {
        private CommandProcessor _commandProcessor;
        private Location _location;
        private Player _player;
        private Item _item;
        private Bag _bag;
        private Paths _paths;

       [SetUp]
       public void Setup()
        {
            _commandProcessor = new CommandProcessor();
            _location = new Location(new string[] { "test_room" }, "Test Room", "where all the testing happens.");
            _player = new Player("Tester", "a game tester");
            _item = new Item(new string[] { "portion" }, "small_portion", "A small heal portion.");
            _bag = new Bag(new string[] { "small", "leather", "bag" }, "small_bag", "a small leather bag");
            _paths = new Paths(new string[] { "testing" }, "testing_path", "The Test Path", _location);

            _player.Inventory.Put(_bag);
            _bag.Inventory.Put(_item);
            _location.AddPath(_paths);
        }

        [Test]
        public void TestLookCommand()
        {
            Assert.AreEqual("You are Tester a game tester\nYou are carrying:\n" + _player.Inventory.ItemList, _commandProcessor.Execute(_player, new string[] { "look", "at", "inventory" }));
        }

        [Test]
        public void TestMoveCommand()
        {
            _player.Location = _location;
            _location.AddPath(_paths);
            _commandProcessor.Execute(_player, new string[] { "move", "to", "testing" });
            Assert.AreEqual(_location.Name, _player.Location.Name);
        }
    }
}
