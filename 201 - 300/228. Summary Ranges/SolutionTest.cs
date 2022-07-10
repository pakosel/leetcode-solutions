using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SummaryRanges
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0,1,2,4,5,7]", new string[] {"0->2","4->5","7"}},
            new object[] {"[0,2,3,4,6,8,9]", new string[] {"0","2->4","6","8->9"}},
            new object[] {"[]", new string[0]},
            new object[] {"[0]", new string[] {"0"}},
            new object[] {"[1,3]", new string[] {"1","3"}},
            new object[] {"[1,3,5]", new string[] {"1","3","5"}},
            new object[] {"[-5,-4,-3,-1,0]", new string[] {"-5->-3","-1->0"}},
            new object[] {"[-2147483648,-2147483647,2147483647]", new string[] {"-2147483648->-2147483647","2147483647"}},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, string[] expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.SummaryRanges(nums);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}