using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOfEnclaves
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[0,0,0,0],[1,0,1,0],[0,1,1,0],[0,0,0,0]]", 3},
            new object[] {"[[0,1,1,0],[0,0,1,0],[0,0,1,0],[0,0,0,0]]", 0},
            new object[] {"[[1]]", 0},
            new object[] {"[[0]]", 0},
            new object[] {"[[0,0,0,0],[0,1,1,0],[0,0,0,0]]", 2},
            new object[] {"[[0,0,0,0],[1,1,1,0],[0,1,1,0],[0,0,0,0]]", 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string gridStr, int expected)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);

            var sol = new Solution();
            var res = sol.NumEnclaves(grid);

            Assert.That(expected == res);
        }
    }
}