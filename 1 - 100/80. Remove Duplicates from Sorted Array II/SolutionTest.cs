using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RemoveDuplicatesFromSortedArrayII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", 0, "[]"},
            new object[] {"[0]", 1, "[0]"},
            new object[] {"[0,0,0,0]", 2, "[0,0]"},
            new object[] {"[1,1,1,2,2,3]", 5, "[1,1,2,2,3]"},
            new object[] {"[0,0,1,1,1,1,2,3,3]", 7, "[0,0,1,1,2,3,3]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string arrStrIn, int expected, string arrStrOut)
        {
            var nums = ArrayHelper.ArrayFromString<int>(arrStrIn);

            var sol = new Solution();
            var res = sol.RemoveDuplicates(nums);

            Assert.That(expected == res);
            
            var targetNums = ArrayHelper.ArrayFromString<int>(arrStrOut);
            CollectionAssert.AreEquivalent(targetNums, nums.Take(expected));
        }
    }
}