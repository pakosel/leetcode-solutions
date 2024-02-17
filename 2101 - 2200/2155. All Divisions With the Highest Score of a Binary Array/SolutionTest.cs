using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace AllDivisionsWithTheHighestScoreOfBinaryArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0,0,1,0]", "[2,4]"},
            new object[] {"[0,0,0]", "[3]"},
            new object[] {"[1,1]", "[0]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.MaxScoreIndices(nums);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}