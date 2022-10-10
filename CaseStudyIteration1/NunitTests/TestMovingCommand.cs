using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CaseStudyIteration1
{
    [TestFixture]
    public class TestMovingCommand
    {
        private MoveCommand _command;
        private Player _player;
        private Location _locA;
        private Paths _paths;

        [SetUp]
        public void Setup()
        {
            _player = new Player("Beta Tester", "The Test Player!");
            _locA = new Location(new string[] { "north city" }, "North City", "The North City District.");
            _command = new MoveCommand();
            _paths = new Paths(new string[] { "north" }, "road", "The North Road", _locA);
        }

        [Test]
        public  void TestMovingPlayer()
        {
            _player.Location = _locA;
            _locA.AddPath(_paths);
            _command.Execute(_player, new string[] {"move","to","north" });

            Assert.AreEqual(_locA.Name, _player.Location.Name);
        }
    }
}
