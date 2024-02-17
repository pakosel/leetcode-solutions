using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ElementAppearingMoreThan25InSortedArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,2,6,6,6,6,7,10]", 6},
            new object[] {"[1,1]", 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string arrStr, int expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.FindSpecialInteger(arr);

            Assert.That(expected == res);
        }
    }
}