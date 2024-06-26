using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;
using NUnit.Framework.Legacy;

namespace Subsets
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[0]", "[[],[0]]"},
            new object[] {"[1]", "[[1],[]]"},
            new object[] {"[1,2]", "[[1],[2],[1,2],[]]"},
            new object[] {"[1,2]", "[[],[2],[1],[2,1]]"},
            new object[] {"[1,2,3]", "[[1],[2],[3],[2,3],[1,2],[1,3],[1,2,3],[]]"},
            new object[] {"[-1,-2,1,-3]", "[[-1],[-2],[1],[-3],[1,-3],[-2,1],[-2,-3],[-2,1,-3],[-1,-2],[-1,1],[-1,-3],[-1,1,-3],[-1,-2,1],[-1,-2,-3],[-1,-2,1,-3],[]]"},
            new object[] {"[0,-1,-2,1,2]", "[[0],[-1],[-2],[1],[2],[1,2],[-2,1],[-2,2],[-2,1,2],[-1,-2],[-1,1],[-1,2],[-1,1,2],[-1,-2,1],[-1,-2,2],[-1,-2,1,2],[0,-1],[0,-2],[0,1],[0,2],[0,1,2],[0,-2,1],[0,-2,2],[0,-2,1,2],[0,-1,-2],[0,-1,1],[0,-1,2],[0,-1,1,2],[0,-1,-2,1],[0,-1,-2,2],[0,-1,-2,1,2],[]]"},
            new object[] {"[1,2,3,4,5,6]", "[[],[6],[5],[6,5],[4],[6,4],[5,4],[6,5,4],[3],[6,3],[5,3],[6,5,3],[4,3],[6,4,3],[5,4,3],[6,5,4,3],[2],[6,2],[5,2],[6,5,2],[4,2],[6,4,2],[5,4,2],[6,5,4,2],[3,2],[6,3,2],[5,3,2],[6,5,3,2],[4,3,2],[6,4,3,2],[5,4,3,2],[6,5,4,3,2],[1],[6,1],[5,1],[6,5,1],[4,1],[6,4,1],[5,4,1],[6,5,4,1],[3,1],[6,3,1],[5,3,1],[6,5,3,1],[4,3,1],[6,4,3,1],[5,4,3,1],[6,5,4,3,1],[2,1],[6,2,1],[5,2,1],[6,5,2,1],[4,2,1],[6,4,2,1],[5,4,2,1],[6,5,4,2,1],[3,2,1],[6,3,2,1],[5,3,2,1],[6,5,3,2,1],[4,3,2,1],[6,4,3,2,1],[5,4,3,2,1],[6,5,4,3,2,1]]"},
            new object[] {"[1,2,3,4,5,6]", "[[],[1],[2],[3],[4],[5],[6],[5,6],[4,5],[4,6],[4,5,6],[3,4],[3,5],[3,6],[3,5,6],[3,4,5],[3,4,6],[3,4,5,6],[2,3],[2,4],[2,5],[2,6],[2,5,6],[2,4,5],[2,4,6],[2,4,5,6],[2,3,4],[2,3,5],[2,3,6],[2,3,5,6],[2,3,4,5],[2,3,4,6],[2,3,4,5,6],[1,2],[1,3],[1,4],[1,5],[1,6],[1,5,6],[1,4,5],[1,4,6],[1,4,5,6],[1,3,4],[1,3,5],[1,3,6],[1,3,5,6],[1,3,4,5],[1,3,4,6],[1,3,4,5,6],[1,2,3],[1,2,4],[1,2,5],[1,2,6],[1,2,5,6],[1,2,4,5],[1,2,4,6],[1,2,4,5,6],[1,2,3,4],[1,2,3,5],[1,2,3,6],[1,2,3,5,6],[1,2,3,4,5],[1,2,3,4,6],[1,2,3,4,5,6]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic2024(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution2024();
            var res = sol.Subsets(nums);

            CollectionAssert.AreEquivalent(res.Select(set => set.OrderBy(_ => _)), expected.Select(set => set.OrderBy(_ => _)));
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.Subsets(nums);

            CollectionAssert.AreEquivalent(res.Select(set => set.OrderBy(_ => _)), expected.Select(set => set.OrderBy(_ => _)));
        }
    }
}