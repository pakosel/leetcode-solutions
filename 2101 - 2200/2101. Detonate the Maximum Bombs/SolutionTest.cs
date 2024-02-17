using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DetonateTheMaximumBombs
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[2,1,3],[6,1,4]]", 2},
            new object[] {"[[1,1,5],[10,10,5]]", 1},
            new object[] {"[[1,2,3],[2,3,1],[3,4,2],[4,5,3],[5,6,4]]", 5},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string bombsStr, int expected)
        {
            var bombs = ArrayHelper.MatrixFromString<int>(bombsStr);

            var sol = new Solution();
            var res = sol.MaximumDetonation(bombs);

            Assert.That(expected == res);
        }
    }
}