using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaxDifferenceYouCanGetFromChangingInteger
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {555, 888},
            new object[] {9, 8},
            new object[] {111, 888},
            new object[] {9288, 8700},
            new object[] {1001, 8008},
            new object[] {1, 8},
            new object[] {10, 80},
            new object[] {100, 800},
            new object[] {13, 83},
            new object[] {123, 820},
            new object[] {246, 800},
            new object[] {654123, 800000},
            new object[] {449999, 880000},
            new object[] {3311111, 8800000},
            
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int num, int expected)
        {
            var sol = new Solution();
            var res = sol.MaxDiff(num);

            Assert.AreEqual(expected, res);
        }
    }
}