using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace Permutations
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,3]", "[[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]"},
            new object[] {"[0,1]", "[[0,1],[1,0]]"},
            new object[] {"[1]", "[[1]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.Permute(nums);

            CollectionAssert.AreEquivalent(expected, res);
        }
    }
}