using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountTheHiddenSequences
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0]", 0, 0, 1},
            new object[] {"[-40]", -46, 53, 60},
            new object[] {"[1,2,3]", 1, 6, 0},
            new object[] {"[1,-3,4]", 1, 6, 2},
            new object[] {"[3,-4,5,1,-2]", -4, 5, 4},
            new object[] {"[4,-7,2]", 3, 6, 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string hiddenStr, int lower, int upper, int expected)
        {
            var hidden = ArrayHelper.ArrayFromString<int>(hiddenStr);

            var sol = new Solution();
            var res = sol.NumberOfArrays(hidden, lower, upper);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}