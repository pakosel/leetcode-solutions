using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RunningSumOf1dArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1]", "[1]"},
            new object[] {"[1,2,3,4]", "[1,3,6,10]"},
            new object[] {"[1,1,1,1,1]", "[1,2,3,4,5]"},
            new object[] {"[3,1,2,10,1]", "[3,4,6,16,17]"},
        };


        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.RunningSum(nums);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}