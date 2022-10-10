using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CaseStudyIteration1
{
    [TestFixture]
    public class TestPath
    {
        private Player _player;
        private Location _LocA;
        private Paths _Path;
        private MoveCommand _MoveCommand;

        [SetUp]
        public void Setup()
        {
            _player = new Player("Beta Tester", "The Test Player!");
            _LocA = new Location(new string[] { "north city" }, "North City", "The North City District.");
            _MoveCommand = new MoveCommand();
            _Path = new Paths(new string[] { "north" }, "road", "The North Road", _LocA);
        }

        [Test]
        public void TestPathLocation()
        {
            _player.Location = _LocA;
            _LocA.AddPath(_Path);
            Assert.AreEqual(_LocA, _Path.Dest);
        }

        [Test]
        public void GetPathFromLocation()
        {
            _player.Location = _LocA;
            _LocA.AddPath(_Path);
            Assert.AreEqual("Moving in The North Road", _Path.FullDescription); ;
        }

        [Test]
        public void TestLocatingPath()
        {
            _player.Location = _LocA;
            _LocA.AddPath(_Path);
            Assert.AreEqual(_LocA.Locate("north"), _Path);
        }

    }
}
