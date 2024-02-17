using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CinemaSeatAllocation

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, "[[1,1]]", 2},
            new object[] {1, "[[1,10]]", 2},
            new object[] {1, "[[1,2]]", 1},
            new object[] {1, "[[1,9]]", 1},
            new object[] {1, "[[1,3],[1,8]]", 1},
            new object[] {3, "[[1,2],[1,3],[1,8],[2,6],[3,1],[3,10]]", 4},
            new object[] {2, "[[2,1],[1,8],[2,6]]", 2},
            new object[] {4, "[[4,3],[1,4],[4,6],[1,7]]", 4},
            new object[] {5, "[[4,7],[4,1],[3,1],[5,9],[4,4],[3,7],[1,3],[5,5],[1,6],[1,8],[3,9],[2,9],[1,4],[1,9],[1,10]]", 2},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int n, string reservedStr, int expected)
        {
            var reserved = ArrayHelper.MatrixFromString<int>(reservedStr);

            var sol = new Solution();
            var res = sol.MaxNumberOfFamilies(n, reserved);

            Assert.That(expected == res);
        }
    }
}