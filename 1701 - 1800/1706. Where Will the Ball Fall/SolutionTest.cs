using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace WhereWillTheBallFall
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,1,1,-1,-1],[1,1,1,-1,-1],[-1,-1,-1,1,1],[1,1,1,1,-1],[-1,-1,-1,-1,-1]]", "[1,-1,-1,-1,-1]"},
            new object[] {"[[-1]]", "[-1]"},
            new object[] {"[[1,1,1,1,1,1],[-1,-1,-1,-1,-1,-1],[1,1,1,1,1,1],[-1,-1,-1,-1,-1,-1]]", "[0,1,2,3,4,-1]"},
            new object[] {"[[1,1,1],[1,1,1]]", "[2,-1,-1]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string gridStr, string expectedStr)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.FindBall(grid);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}