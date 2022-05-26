using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximalSquare
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", 0},
            new object[] {"[[1]]", 1},
            new object[] {"[[0]]", 0},
            new object[] {"[[0,0]]", 0},
            new object[] {"[[0,1],[1,0]]", 1},
            new object[] {"[[1,0,1,0,0],[1,0,1,1,1],[1,1,1,1,1],[1,0,0,1,0]]", 4},
            new object[] {"[[1,0,1,0,0],[1,0,1,1,1],[1,1,1,1,1],[1,0,0,1,0]]", 4},
            new object[] {"[[0,0,0,0,0,0,1],[0,0,0,0,1,1,1],[1,1,1,1,1,1,1],[0,0,0,1,1,1,1]]", 9},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string charMatrix, int expected)
        {
            var matrix = ArrayHelper.MatrixFromString<char>(charMatrix);

            var sol = new Solution();
            var res = sol.MaximalSquare(matrix);

            Assert.AreEqual(res, expected);
        }
    }
}