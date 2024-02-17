using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumSumOfFourDigitNumberAfterSplittingDigits
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {2932, 52},
            new object[] {4009, 13},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int num, int expected)
        {
            var sol = new Solution();
            var res = sol.MinimumSum(num);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}