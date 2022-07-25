using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PositionsInSortedArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[5,7,7,8,8,10]", 8, "[3,4]"},
            new object[] {"[5,7,7,8,8,10]", 6, "[-1,-1]"},
            new object[] {"[5,7,7,8,8,10]", 16, "[-1,-1]"},
            new object[] {"[]", 0, "[-1,-1]"},
            new object[] {"[5,7,7,8,8,10]", 9, "[-1,-1]"},
            new object[] {"[2,2]", 2, "[0,1]"},
            new object[] {"[1,4]", 4, "[1,1]"},
            new object[] {"[0,1,2,3,4,4,4]", 2, "[2,2]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, int target, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.SearchRange(nums, target);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}