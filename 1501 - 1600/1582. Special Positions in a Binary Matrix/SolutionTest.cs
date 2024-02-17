using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SpecialPositionsInBinaryMatrix
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,0,0],[0,0,1],[1,0,0]]", 1},
            new object[] {"[[1,0,0],[0,1,0],[0,0,1]]", 3},
            new object[] {"[[0,0,0,1],[1,0,0,0],[0,1,1,0],[0,0,0,0]]", 2},
            
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string matStr, int expected)
        {
            var mat = ArrayHelper.MatrixFromString<int>(matStr);

            var sol = new Solution();
            var res = sol.NumSpecial(mat);

            Assert.That(expected == res);
        }
    }
}