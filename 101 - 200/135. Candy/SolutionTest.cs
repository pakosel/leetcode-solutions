using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace Candy
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new int[] {}, 0},
            new object[] { new int[] {1}, 1},
            new object[] { new int[] {1,1}, 2},
            new object[] { new int[] {1,1,1}, 3},
            new object[] { new int[] {1,0,2}, 5},
            new object[] { new int[] {1,2,2}, 4},
            new object[] { new int[] {1,2,87,87,87,2,1}, 13},
            new object[] { new int[] {1,2,2,2,2,2,2,1}, 10},
            new object[] { new int[] {1,3,2,2,1}, 7},
            new object[] { new int[] {1,3,4,5,2}, 11},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int[] ratings, int expected)
        {
            var sol = new Solution();
            var res = sol.Candy(ratings);

            Assert.AreEqual(expected, res);
        }
    }
}