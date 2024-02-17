using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace GameOfLife
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,1],[1,0]]", "[[1,1],[1,1]]"},
            new object[] {"[[0,1,0],[0,0,1],[1,1,1],[0,0,0]]", "[[0,0,0],[1,0,1],[0,1,1],[0,1,0]]"},
            new object[] {"[[0]]", "[[0]]"},
            new object[] {"[[1]]", "[[0]]"},
            new object[] {"[[0,0]]", "[[0,0]]"},
            new object[] {"[[0,1]]", "[[0,0]]"},
            new object[] {"[[1,0]]", "[[0,0]]"},
            new object[] {"[[0],[0]]", "[[0],[0]]"},
            new object[] {"[[0],[1]]", "[[0],[0]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string gridStr, string expectedStr)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            sol.GameOfLife(grid);

            Assert.That(grid, Is.EqualTo(expected));
        }
    }
}