using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace CombinationSumII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new int[] {10,1,2,7,6,1,5}, 8, new List<IList<int>> {new int[] {1,1,6}, new int[] {1,2,5}, new int[] {1,7}, new int[] {2,6}} },
            new object[] {new int[] {2,5,2,1,2}, 5, new List<IList<int>> {new int[] {1,2,2}, new int[] {5}}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int[] candidates, int target, IList<IList<int>> expected)
        {
            var sol = new Solution();
            var res = sol.CombinationSum2(candidates, target);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}