using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MatrixDiagonalSum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,2,3],[4,5,6],[7,8,9]]", 25},
            new object[] {"[[1,1,1,1],[1,1,1,1],[1,1,1,1],[1,1,1,1]]", 8},
            new object[] {"[[5]]", 5},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string matStr, int expected)
        {
            var mat = ArrayHelper.MatrixFromString<int>(matStr);

            var sol = new Solution();
            var res = sol.DiagonalSum(mat);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}