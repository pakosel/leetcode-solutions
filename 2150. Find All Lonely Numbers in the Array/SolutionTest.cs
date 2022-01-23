using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindAllLonelyNumbersInTheArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[10,6,5,8]", "[10,8]"},
            new object[] {"[1,3,5,3]", "[1,5]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString(numsStr);
            var expected = ArrayHelper.ArrayFromString(expectedStr);

            var sol = new Solution();
            var res = sol.FindLonely(nums);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}