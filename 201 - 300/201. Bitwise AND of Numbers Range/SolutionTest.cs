using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BitwiseAndOfNumbersRange
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {5,7, 4},
            new object[] {0,0, 0},
            new object[] {1,2147483647, 0},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int left, int right, int expected)
        {
            var sol = new Solution();
            var res = sol.RangeBitwiseAnd(left, right);

            Assert.That(res == expected);
        }
    }
}