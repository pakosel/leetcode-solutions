using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumCostOfBuyingCandiesWithDiscount
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3]", 5},
            new object[] {"[6,5,7,9,2,2]", 23},
            new object[] {"[5,5]", 10},
            new object[] {"[1]", 1},
            new object[] {"[1,2]", 3},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string arrStr, int expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.MinimumCost(arr);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}