using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace AddDigits
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {0, 0},
            new object[] {1, 1},
            new object[] {2, 2},
            new object[] {38, 2},
            new object[] {127, 1},
            new object[] {3562, 7},
            new object[] {8934341, 5},
            new object[] {2147483646, 9},
            new object[] {2147483647, 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int num, int expected)
        {
            var sol = new Solution();
            var ret = sol.AddDigits(num);

            Assert.That(expected == ret);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Math(int num, int expected)
        {
            var sol = new Solution_Math();
            var ret = sol.AddDigits(num);

            Assert.That(expected == ret);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Div(int num, int expected)
        {
            var sol = new Solution_Div();
            var ret = sol.AddDigits(num);

            Assert.That(expected == ret);
        }
    }
}