using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RearrangeArrayElementsBySign
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[3,1,-2,-5,2,-4]", "[3,-2,1,-5,2,-4]"},
            new object[] {"[-1,1]", "[1,-1]"},
            new object[] {"[-1,-2,-3,-4,-5,5,4,3,2,1]", "[5,-1,4,-2,3,-3,2,-4,1,-5]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString(numsStr);
            var expected = ArrayHelper.ArrayFromString(expectedStr);

            var sol = new Solution();
            var res = sol.RearrangeArray(nums);

            CollectionAssert.AreEqual(res, expected);
        }
    }
}