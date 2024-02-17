using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PartitioningIntoMinimumNumberOfDeciBinaryNumbers
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"1", 1},
            new object[] {"10", 1},
            new object[] {"32", 3},
            new object[] {"1234", 4},
            new object[] {"4321", 4},
            new object[] {"82734", 8},
            new object[] {"27346209830709182346", 9},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic2022(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.MinPartitions(s);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.MinPartitions(s);

            Assert.That(expected == res);
        }
    }
}