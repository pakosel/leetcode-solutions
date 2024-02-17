using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ArithmeticSlices
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,3,4]", 3},
            new object[] {"[1]", 0},
            new object[] {"[1,2]", 0},
            new object[] {"[1,2,3]", 1},
            new object[] {"[-10,-7,-10]", 0},
            new object[] {"[-10,-7,-4]", 1},
            new object[] {"[-10,-7,-4,-1]", 3},
            new object[] {"[-10,-7,-4,-1,1]", 3},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string strArray, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(strArray);

            var sol = new Solution();
            var res = sol.NumberOfArithmeticSlices(nums);

            Assert.That(expected == res);
        }
    }
}