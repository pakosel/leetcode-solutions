using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LongestSubarrayOf1sAfterDeletingOneElement
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0]", 0},
            new object[] {"[1]", 0},
            new object[] {"[1,1,0,1]", 3},
            new object[] {"[0,0,1,1]", 2},
            new object[] {"[0,1,1,1,0,1,1,0,1]", 5},
            new object[] {"[1,1,1]", 2},
            new object[] {"[1,0,0,0,0]", 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.LongestSubarray(nums);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}