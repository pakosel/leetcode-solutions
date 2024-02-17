using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SingleNumberIII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[1,2,1,3,2,5]", "[3,5]" },
            new object[] { "[-1,0]", "[-1,0]" },
            new object[] { "[0,1]", "[0,1]" },
            new object[] { "[0,2147483647,1,2147483647]", "[0,1]" },
            new object[] { "[0,2147483647,0,-2147483647]", "[2147483647,-2147483647]" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.SingleNumber(nums);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}