using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumTotalImportanceOfRoads
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {5, "[[0,1],[1,2],[2,3],[0,2],[1,3],[2,4]]", 43},
            new object[] {5, "[[0,3],[2,4],[1,3]]", 20},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, string roadsStr, int expected)
        {
            var roads = ArrayHelper.MatrixFromString<int>(roadsStr);

            var sol = new Solution();
            var res = sol.MaximumImportance(n, roads);

            Assert.That(expected == res);
        }
    }
}