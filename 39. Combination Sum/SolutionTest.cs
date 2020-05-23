using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace CombinationSum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new int[0], 7, new int[0][]},
            new object[] {new int[] {2,3,6,7}, 7, new int[][] {new int[]{7}, new int[]{2,2,3}}},
            new object[] {new int[] {3,5}, 8, new int[][] {new int[] {3,5}}},
            new object[] {new int[] {2,3,5}, 8, new int[][] {new int[] {3,5}, new int[] {2,3,3},new int[] {2,2,2,2}}},
            new object[] {new int[] {2,5,8,4}, 10, new int[][] {new int[] {2,2,2,2,2}, new int[] {2,2,2,4}, new int[] {2,4,4}, new int[] {2,8}, new int[] {5,5}}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int[] candidates, int target, IList<IList<int>> expected)
        {
            var sol = new Solution();
            var res = sol.CombinationSum(candidates, target);

            CollectionAssert.AreEquivalent(res.Select(x => x.OrderBy(y => y)), expected);
            //above is equivalent of the following:
            // Assert.AreEqual(res.Count, expected.Count);
            // foreach(var e in res)
            //     Assert.IsTrue(expected.Any(l => l.SequenceEqual(e.OrderBy(x => x))));
        }
    }
}