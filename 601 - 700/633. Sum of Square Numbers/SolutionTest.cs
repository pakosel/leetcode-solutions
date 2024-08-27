using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SumOfSquareNumbers
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {5, true},
            new object[] {3, false},
            new object[] {0, true},
            new object[] {4, true},
            new object[] {199960002, true},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int c, bool expected)
        {
            var sol = new Solution();
            var res = sol.JudgeSquareSum(c);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}