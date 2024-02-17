using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RectangleArea
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {-3, 0, 3, 4, 0, -1, 9, 2, 45},
            new object[] {-2, -2, 2, 2, -2, -2, 2, 2, 16},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2, int expected)
        {
            var sol = new Solution();
            var res = sol.ComputeArea(ax1, ay1, ax2, ay2, bx1, by1, bx2, by2);

            Assert.That(expected == res);
        }
    }
}