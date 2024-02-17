using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindTheHighestAltitude
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[-5,1,5,0,-7]", 1},
            new object[] {"[-4,-3,-2,-1,4,3,2]", 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string gainStr, int expected)
        {
            var gain = ArrayHelper.ArrayFromString<int>(gainStr);

            var sol = new Solution();
            var res = sol.LargestAltitude(gain);

            Assert.That(expected == res);
        }
    }
}