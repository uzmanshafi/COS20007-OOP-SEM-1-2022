using System;
using NUnit.Framework;

namespace Clock
{
    [TestFixture]
    public class CounterTests
    {
        Counter testcounter = new Counter("Testing");

        [Test]
        public void TestCounterIsZero()
        {
            Assert.AreEqual(0, testcounter.Tick);
        }

        [Test]
        public void TestIncrementCounter()
        {
            int oldVal = testcounter.Tick;
            int newVal = oldVal + 1;

            testcounter.Increment();
            Assert.AreEqual(newVal, testcounter.Tick);
        }

        [Test]
        public void TestCounterMultiples()
        {
            int oldVal = testcounter.Tick;
            int newVal = oldVal + 5;

            for(int i = 0; i < newVal; i++)
            {
                testcounter.Increment();
            }

            Assert.AreEqual(newVal, testcounter.Tick);
        }

        [Test]
        public void TestCounterReset()
        {
            testcounter.Increment();
            testcounter.Reset();
            Assert.AreEqual(0, testcounter.Tick);
        }
    }
}