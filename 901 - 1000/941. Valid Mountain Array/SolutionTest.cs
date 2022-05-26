using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ValidMountainArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2]", false},
            new object[] {"[1,2,1]", true},
            new object[] {"[2,1]", false},
            new object[] {"[3,5,5]", false},
            new object[] {"[0,3,2,1]", true},
            new object[] {"[0,1,2,1,2]", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Memoization(string arrStr, bool expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.ValidMountainArray(arr);

            Assert.AreEqual(res, expected);
        }
    }
}