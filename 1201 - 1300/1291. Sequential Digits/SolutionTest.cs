using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SequentialDigits
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {10, 10, "[]"},
            new object[] {100, 300, "[123,234]"},
            new object[] {1000, 13000, "[1234,2345,3456,4567,5678,6789,12345]"},
            new object[] {200, 100000, "[234,345,456,567,678,789,1234,2345,3456,4567,5678,6789,12345,23456,34567,45678,56789]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int low, int high, string expectedStr)
        {
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.SequentialDigits(low, high);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}