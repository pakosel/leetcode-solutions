using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace Largest3SameDigitNumberInString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"6777133339", "777"},
            new object[] {"2300019", "000"},
            new object[] {"42352338", ""},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string num, string expected)
        {
            var sol = new Solution();
            var res = sol.LargestGoodInteger(num);

            Assert.AreEqual(expected, res);
        }
    }
}