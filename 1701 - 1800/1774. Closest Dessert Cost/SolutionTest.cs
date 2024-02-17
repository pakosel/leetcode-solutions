using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ClosestDessertCost
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,7]", "[3,4]", 10, 10},
            new object[] {"[2,3]", "[4,5,100]", 18, 17},
            new object[] {"[3,10]", "[2,5]", 9, 8},
            new object[] {"[10]", "[1]", 1, 10},
            new object[] {"[8,4,4,5,8]", "[3,10,9,10,8,10,10,9,3]", 6, 5},
            new object[] {"[2,9,10,5,4,9,8,8,1]", "[9,3,10,9]", 3, 2},
            new object[] {"[4]", "[9]", 9, 13},
            new object[] {"[8,4,4,5,8]", "[3,10,9,10,8,10,10,9,3]", 6, 5},
            new object[] {"[5,2,4,9]", "[10,10,9]", 8, 9},
            new object[] {"[3,2]", "[3]", 10, 9},
            new object[] {"[3738,5646,197,7652]", "[5056]", 9853, 10309},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string baseStr, string toppingsStr, int target, int expected)
        {
            var baseCosts = ArrayHelper.ArrayFromString<int>(baseStr);
            var toppingCosts = ArrayHelper.ArrayFromString<int>(toppingsStr);

            var sol = new Solution();
            var res = sol.ClosestCost(baseCosts, toppingCosts, target);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}