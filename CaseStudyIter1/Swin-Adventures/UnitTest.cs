using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CaseStudyIter1
{
    [TestFixture]
    public class UnitTest
    {
        Identifiable_Object id = new Identifiable_Object(new string[] {"id1", "id2"});

        [Test]
        public void TestAreYou()
        {
            Console.WriteLine("uhuhu");
            Assert.IsTrue(id.AreYou("id1"));
        }
    }
}
