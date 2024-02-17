using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ExcelSheetColumnNumber
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"A", 1},
            new object[] {"AB", 28},
            new object[] {"ZY", 701},
            new object[] {"FTGHJWE", 2094468979},
            new object[] {"FXSHRXW", 2147483647},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string columnTitle, int expected)
        {
            var sol = new Solution();
            var res = sol.TitleToNumber(columnTitle);

            Assert.That(expected == res);
        }
    }
}