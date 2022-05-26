using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumBagsWithFullCapacityOfRocks
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0]", "[0]", 1, 1},
            new object[] {"[2,3,4,5]", "[1,2,4,4]", 2, 3},
            new object[] {"[10,2,2]", "[2,2,0]", 100, 3},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string capacityStr, string rocksStr, int additionalRocks, int expected)
        {
            var capacity = ArrayHelper.ArrayFromString<int>(capacityStr);
            var rocks = ArrayHelper.ArrayFromString<int>(rocksStr);

            Assert.AreEqual(capacity.Length, rocks.Length);

            var sol = new Solution();
            var res = sol.MaximumBags(capacity, rocks, additionalRocks);

            Assert.AreEqual(expected, res);
        }
    }
}