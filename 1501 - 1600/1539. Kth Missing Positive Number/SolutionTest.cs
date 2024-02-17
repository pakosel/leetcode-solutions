using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace KthMissingPositiveNumber
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2,3,4,7,11]", 5, 9},
            new object[] {"[1,2,3,4]", 2, 6},
            new object[] {"[2,3,4,7,11]", 1, 1},
            new object[] {"[2,3,4,7,11]", 2, 5},
            new object[] {"[2,3,4,7,11]", 100, 105},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string arrStr, int k, int expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.FindKthPositive(arr, k);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}