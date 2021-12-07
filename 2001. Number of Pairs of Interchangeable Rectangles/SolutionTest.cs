using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOfPairsOfInterchangeableRectangles
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[4,8],[3,6],[10,20],[15,30]]", 6},
            new object[] {"[[4,5],[7,8]]", 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string rectanglesStr, int expected)
        {
            var rectangles = ArrayHelper.MatrixFromString(rectanglesStr);

            var sol = new Solution();
            var res = sol.InterchangeableRectangles(rectangles);

            Assert.AreEqual(res, expected);
        }
    }
}