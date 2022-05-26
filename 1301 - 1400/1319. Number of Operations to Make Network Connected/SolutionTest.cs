using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOfOperationsToMakeNetworkConnected
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {4, "[[[0,1],[0,2],[1,2]]]", 1},
            new object[] {6, "[[0,1],[0,2],[0,3],[1,2],[1,3]]", 2},
            new object[] {6, "[[0,1],[0,2],[0,3],[1,2]]", -1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int n, string connectionsStr, int expected)
        {
            var connections = ArrayHelper.MatrixFromString<int>(connectionsStr);

            var sol = new Solution();
            var res = sol.MakeConnected(n, connections);

            Assert.AreEqual(res, expected);
        }
    }
}