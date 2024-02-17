using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LongestContinuousSubarrayWithAbsoluteDiffLessThanEqualLimit
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0]", 0, 1},
            new object[] {"[4,2]", 2, 2},
            new object[] {"[4,8]", 4, 2},
            new object[] {"[2,2]", 0, 2},
            new object[] {"[4,8]", 2, 1},
            new object[] {"[1,2,3,4,5,6,7,8,9,2]", 4, 5},
            new object[] {"[4,2,2,2,4,4,2,2]", 0, 3},
            new object[] {"[10,1,2,4,7,2]", 5, 4},
            new object[] {"[8,2,4,7]", 4, 2},
            
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string arrStr, int limit, int expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.LongestSubarray(arr, limit);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}