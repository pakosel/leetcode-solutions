using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace EqualRowAndColumnPairs
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[3,2,1],[1,7,6],[2,7,7]]", 1},
            new object[] {"[[3,1,2,2],[1,4,4,5],[2,4,2,2],[2,4,2,2]]", 3},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string gridStr, int expected)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);
            
            var sol = new Solution();
            var res = sol.EqualPairs(grid);

            Assert.That(expected == res);
        }
    }
}