using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindIfPathExistsInGraph
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {3, "[[0,1],[1,2],[2,0]]", 0, 2, true},
            new object[] {6, "[[0,1],[0,2],[3,5],[5,4],[4,3]]", 0, 5, false},
            
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, string edgesStr, int source, int destination, bool expected)
        {
            var edges = ArrayHelper.MatrixFromString<int>(edgesStr);

            var sol = new Solution();
            var res = sol.ValidPath(n, edges, source, destination);

            Assert.AreEqual(expected, res);
        }
    }
}