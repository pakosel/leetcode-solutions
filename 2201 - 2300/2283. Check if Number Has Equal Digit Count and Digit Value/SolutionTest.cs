using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CheckIfNumberHasEqualDigitCountAndDigitValue
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"1210", true},
            new object[] {"030", false},
            new object[] {"0", false},
            new object[] {"1", false},
            new object[] {"120", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string num, bool expected)
        {
            var sol = new Solution();
            var res = sol.DigitCount(num);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}