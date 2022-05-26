using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LongestMountainInArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[]", 0},
            new object[] {"[1]", 0},
            new object[] {"[1,2]", 0},
            new object[] {"[1,2,3]", 0},
            new object[] {"[1,3,2]", 3},
            new object[] {"[2,1,4,7,3,2]", 5},
            new object[] {"[2,1,4,7,3,2,5]", 5},
            new object[] {"[2,1,4,7,7,3,2,5]", 0},
            new object[] {"[2,2,2]", 0},
            new object[] {"[9,8,7,6,5,4,3,2,1,0]", 0},
            new object[] {"[1,2,0,2,0,2]", 3},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Memoization(string arrStr, int expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.LongestMountain(arr);

            Assert.AreEqual(res, expected);
        }
    }
}