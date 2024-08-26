using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MagicSquaresInGrid

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[4,3,8,4],[9,5,1,9],[2,7,6,2]]", 1},
            new object[] {"[[8]]", 0},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string gridStr, int expected)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);

            var sol = new Solution();
            var res = sol.NumMagicSquaresInside(grid);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}