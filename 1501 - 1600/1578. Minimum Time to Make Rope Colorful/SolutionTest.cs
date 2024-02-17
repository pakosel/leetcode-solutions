using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumTimeToMakeRopeColorful
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"abaac", "[1,2,3,4,5]", 3},
            new object[] {"abc", "[1,2,3]", 0},
            new object[] {"aabaa", "[1,2,3,4,1]", 2},
            new object[] {"aaabbbbccc", "[1,3,1,2,2,3,1,7,8,9]", 22},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string colors, string neededTimeStr, int expected)
        {
            var neededTime = ArrayHelper.ArrayFromString<int>(neededTimeStr);

            var sol = new Solution();
            var res = sol.MinCost(colors, neededTime);

            Assert.That(expected == res);
        }
    }
}