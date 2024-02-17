using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
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
            var input = ArrayHelper.ArrayFromString<int>(arrStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.PermuteUnique(input);

            CollectionAssert.AreEquivalent(res, expected);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericList(string arrStr, string expectedStr)
        {
            var input = ArrayHelper.ArrayFromString<int>(arrStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution_List();
            var res = sol.PermuteUnique(input);

            CollectionAssert.AreEquivalent(res, expected);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericMemo(string arrStr, string expectedStr)
        {
            var input = ArrayHelper.ArrayFromString<int>(arrStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution_Memoization();
            var res = sol.PermuteUnique(input);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}