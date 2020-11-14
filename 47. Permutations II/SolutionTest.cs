using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PermutationsII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[0]", "[[0]]"},
            new object[] {"[0,0]", "[[0,0]]"},
            new object[] {"[0,1]", "[[0,1],[1,0]]"},
            new object[] {"[1,1]", "[[1,1]]"},
            new object[] {"[1,1,1]", "[[1,1,1]]"},
            new object[] {"[1,1,2]", "[[1,1,2],[1,2,1],[2,1,1]]"},
            new object[] {"[1,2,3]", "[[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]"},
            new object[] {"[0,0,0,1,1,1]", "[[0,0,0,1,1,1],[0,0,1,0,1,1],[0,0,1,1,0,1],[0,0,1,1,1,0],[0,1,0,0,1,1],[0,1,0,1,0,1],[0,1,0,1,1,0],[0,1,1,0,0,1],[0,1,1,0,1,0],[0,1,1,1,0,0],[1,0,0,0,1,1],[1,0,0,1,0,1],[1,0,0,1,1,0],[1,0,1,0,0,1],[1,0,1,0,1,0],[1,0,1,1,0,0],[1,1,0,0,0,1],[1,1,0,0,1,0],[1,1,0,1,0,0],[1,1,1,0,0,0]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string arrStr, string expectedStr)
        {
            var input = ArrayHelper.ArrayFromString(arrStr);
            var expected = ArrayHelper.MatrixFromString(expectedStr);

            var sol = new Solution();
            var res = sol.PermuteUnique(input);

            CollectionAssert.AreEqual(res, expected);
        }
    }
}