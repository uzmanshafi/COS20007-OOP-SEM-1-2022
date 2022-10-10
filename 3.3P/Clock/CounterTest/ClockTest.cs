using System;
using NUnit.Framework;

namespace Clock
{
    [TestFixture]
    public class ClockTests
    {
        private Clock testclock;

        [SetUp]
        public void Setup()
        {
            testclock = new Clock();
        }

        [Test]
        public void TestClockStartsFromZero()
        {
            string time = testclock.time;
            Assert.AreEqual("00:00:00", time);
        }

        [Test]
        public void TestClockSecondsIncrement()
        {
            testclock.Tick();
            Assert.AreEqual("00:00:01", testclock.time);
        }

        [Test]
        public void TestClockMinutesIncrement()
        {
            for (int s = 0; s < 60; s++) //60 seconds for 1 mintue
            {
                testclock.Tick();
            }
            Assert.AreEqual("00:01:00", testclock.time);
        }

        [Test]
        public void TestClockHoursIncrement()
        {
            for (int s = 0; s < 3600; s++) //3600 seconds for 1 hour
            {
                testclock.Tick();
            }
            Assert.AreEqual("01:00:00", testclock.time);
        }

    }
}