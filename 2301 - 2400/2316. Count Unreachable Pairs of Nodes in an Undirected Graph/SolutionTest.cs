using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountUnreachablePairsOfNodesInAnUndirectedGraph
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {3, "[[0,1],[0,2],[1,2]]", 0},
            new object[] {7, "[[0,2],[0,5],[2,4],[1,6],[5,4]]", 14},
            new object[] {5, "[]", 10},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, string edgesStr, long expected)
        {
            var edges = ArrayHelper.MatrixFromString<int>(edgesStr);
            
            var sol = new Solution();
            var res = sol.CountPairs(n, edges);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}