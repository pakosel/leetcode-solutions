using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ConstructQuadTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[0]]", "[[1,0]]"},
            new object[] {"[[1]]", "[[1,1]]"},
            new object[] {"[[0,1],[1,0]]", "[[0,1],[1,0],[1,1],[1,1],[1,0]]"},
            new object[] {"[[1,1,1,1,0,0,0,0],[1,1,1,1,0,0,0,0],[1,1,1,1,1,1,1,1],[1,1,1,1,1,1,1,1],[1,1,1,1,0,0,0,0],[1,1,1,1,0,0,0,0],[1,1,1,1,0,0,0,0],[1,1,1,1,0,0,0,0]]", "[[0,1],[1,1],[0,1],[1,1],[1,0],null,null,null,null,[1,0],[1,0],[1,1],[1,1]]"},
            
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string gridStr, string expectedStr)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);
            // var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.Construct(grid);

            // CollectionAssert.AreEquivalent(expected, res);
        }
    }
}