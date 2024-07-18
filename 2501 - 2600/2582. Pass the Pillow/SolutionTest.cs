using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PassThePillow
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {2, 3, 2},
            new object[] {2, 4, 1},
            new object[] {3, 1, 2},
            new object[] {3, 2, 3},
            new object[] {3, 3, 2},
            new object[] {3, 4, 1},
            new object[] {3, 5, 2},
            new object[] {3, 6, 3},
            new object[] {3, 7, 2},
            new object[] {3, 8, 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int n, int time, int expected)
        {
            var sol = new Solution();
            var res = sol.PassThePillow(n, time);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}