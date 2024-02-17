using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DivideTwoIntegers
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {10, 3, 3},
            new object[] {7, -3, -2},
            new object[] {-2147483648, -1, 2147483647},
            new object[] {-2147483648, -2147483648, 1},
            new object[] {-2147483648, 2147483647, -1},
            new object[] {-1, 1, -1},
            new object[] {0, 7777, 0},
            new object[] {0, -1, 0},
            new object[] {-1, 7, 0},
            new object[] {97, 13, 7},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int dividend, int divisor, int expected)
        {
            var sol = new Solution();
            var res = sol.Divide(dividend, divisor);

            Assert.That(expected == res);
        }
    }
}