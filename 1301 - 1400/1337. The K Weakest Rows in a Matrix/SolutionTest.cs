using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TheKWeakestRowsInMatrix
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,1,0,0,0],[1,1,1,1,0],[1,0,0,0,0],[1,1,0,0,0],[1,1,1,1,1]]", 3, "[2,0,3]"},
            new object[] {"[[1,0,0,0],[1,1,1,1],[1,0,0,0],[1,0,0,0]]", 2, "[0,2]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string matStr, int k, string expectedStr)
        {
            var mat = ArrayHelper.MatrixFromString<int>(matStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.KWeakestRows(mat, k);

            CollectionAssert.AreEqual(res, expected);
        }
    }
}