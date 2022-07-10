using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindTheDistanceValueBetweenTwoArrays

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0]", "[0]", 0, 0},
            new object[] {"[7]", "[1]", 1, 1},
            new object[] {"[7]", "[1]", 6, 0},
            new object[] {"[1]", "[7]", 6, 0},
            new object[] {"[4,5,8]", "[10,9,1,8]", 2, 2},
            new object[] {"[1,4,2,3]", "[-4,-3,6,10,20,30]", 3, 2},
            new object[] {"[2,1,100,3]", "[-5,-2,10,-3,7]", 6, 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string arr1Str, string arr2Str, int d, int expected)
        {
            var arr1 = ArrayHelper.ArrayFromString<int>(arr1Str);
            var arr2 = ArrayHelper.ArrayFromString<int>(arr2Str);

            var sol = new Solution();
            var res = sol.FindTheDistanceValue(arr1, arr2, d);

            Assert.AreEqual(expected, res);
        }
    }
}