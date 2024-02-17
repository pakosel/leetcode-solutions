using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RestoreTheArrayFromAdjacentPairs
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[2,1],[3,4],[3,2]]", "[1,2,3,4]"},
            new object[] {"[[2,1],[3,4],[3,2]]", "[4,3,2,1]"},
            new object[] {"[[4,-2],[1,4],[-3,1]]", "[-2,4,1,-3]"},
            new object[] {"[[4,-2],[1,4],[-3,1]]", "[-3,1,4,-2]"},
            new object[] {"[[100000,-100000]]", "[100000,-100000]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string adjacentPairsStr, string  expectedStr)
        {
            var adjacentPairs = ArrayHelper.MatrixFromString<int>(adjacentPairsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.RestoreArray(adjacentPairs);

            ClassicAssert.IsTrue(expected.SequenceEqual(res) || expected.SequenceEqual(res.Reverse()));
        }
    }
}