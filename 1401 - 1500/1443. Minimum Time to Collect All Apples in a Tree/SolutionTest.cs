using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumTimeToCollectAllApplesInTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {7, "[[0,1],[0,2],[1,4],[1,5],[2,3],[2,6]]", "[false,false,true,false,true,true,false]", 8},
            new object[] {7, "[[0,1],[0,2],[1,4],[1,5],[2,3],[2,6]]", "[false,false,true,false,false,true,false]", 6},
            new object[] {7, "[[0,1],[0,2],[1,4],[1,5],[2,3],[2,6]]", "[false,false,false,false,false,false,false]", 0},
            new object[] {4, "[[0,2],[0,3],[1,2]]", "[false,true,false,false]", 4},
            new object[] {7, "[[0,1],[0,2],[1,4],[1,5],[2,3],[2,6]]", "[true,true,true,true,true,true,true]", 12},
            new object[] {7, "[[0,1],[0,2],[1,4],[1,5],[2,3],[2,6]]", "[false,true,true,true,true,true,true]", 12},
            new object[] {7, "[[0,1],[0,2],[1,4],[1,5],[2,3],[2,6]]", "[true,false,false,false,false,false,false]", 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int n, string edgesStr, string hasAppleStr, int expected)
        {
            var edges = ArrayHelper.MatrixFromString<int>(edgesStr);
            var hasApple = ArrayHelper.ArrayFromString<bool>(hasAppleStr);
            ClassicAssert.AreEqual(n, hasApple.Length);

            var sol = new Solution();
            var res = sol.MinTime(n, edges, hasApple);

            Assert.That(expected == res);
        }
    }
}