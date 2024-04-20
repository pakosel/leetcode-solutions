using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace IslandPerimeter
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[0,1,0,0],[1,1,1,0],[0,1,0,0],[1,1,0,0]]", 16},
            new object[] {"[[1]]", 4},
            new object[] {"[[1,0]]", 4},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string gridStr, int expected)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);

            var sol = new Solution();
            var res = sol.IslandPerimeter(grid);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}