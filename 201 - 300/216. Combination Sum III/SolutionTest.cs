using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CombinationSumIII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {2, 1, "[]"},
            new object[] {2, 2, "[]"},
            new object[] {4, 1, "[]"},
            new object[] {3, 7, "[[1,2,4]]"},
            new object[] {3, 9, "[[1,2,6],[1,3,5],[2,3,4]]"},
            new object[] {2, 3, "[[1,2]]"},
            new object[] {5, 35, "[[8,9,7,6,5]]"},
            new object[] {6, 36, "[[8,9,7,6,5,1],[8,9,7,6,4,2],[8,9,7,5,4,3]]"},
            new object[] {6, 38, "[[8,9,7,6,5,3]]"},
            new object[] {6, 39, "[[8,9,7,6,5,4]]"},
            new object[] {7, 35, "[[8,9,7,5,3,2,1],[8,9,6,5,4,2,1],[7,9,6,5,4,3,1],[7,8,6,5,4,3,2]]"},
            new object[] {7, 36, "[[8,9,7,6,3,2,1],[8,9,7,5,4,2,1],[8,9,6,5,4,3,1],[7,9,6,5,4,3,2]]"},
            new object[] {7, 37, "[[8,9,7,6,4,2,1],[8,9,7,5,4,3,1],[8,9,6,5,4,3,2]]"},
            new object[] {8, 39, "[[8,9,7,5,4,3,2,1]]"},
            new object[] {9, 45, "[[8,9,7,6,5,4,3,2,1]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(int k, int n, string expectedStr)
        {
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.CombinationSum3(k, n);

            CollectionAssert.AreEquivalent(expected.Select(list => list.OrderBy(_ => _)), res.Select(list => list.OrderBy(_ => _)));
        }
    }
}