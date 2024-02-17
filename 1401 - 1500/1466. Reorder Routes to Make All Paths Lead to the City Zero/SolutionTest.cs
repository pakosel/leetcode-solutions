using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ReorderRoutesToMakeAllPathsLeadToTheCityZero
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {6, "[[0,1],[1,3],[2,3],[4,0],[4,5]]", 3},
            new object[] {5, "[[1,0],[1,2],[3,2],[3,4]]", 2},
            new object[] {3, "[[1,0],[2,0]]", 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, string connectionsStr, int expected)
        {
            var connections = ArrayHelper.MatrixFromString<int>(connectionsStr);

            var sol = new Solution();
            var res = sol.MinReorder(n, connections);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}