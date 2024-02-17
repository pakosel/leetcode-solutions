using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountGoodMeals
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,3,5,7,9]", 4},
            new object[] {"[1,1,1,3,3,3,7]", 15},
            new object[] {"[1,1]", 1},
            new object[] {"[1,1,0]", 3},
            new object[] {"[1,1,1]", 3},
            new object[] {"[1,1,1,1]", 6},
            new object[] {"[1,1,1,1,1]", 10},
            new object[] {"[1,1,1,1,1,1,0]", 21},
            new object[] {"[0]", 0},
            new object[] {"[0,0]", 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.CountPairs(nums);

            Assert.That(expected == res);
        }
    }
}