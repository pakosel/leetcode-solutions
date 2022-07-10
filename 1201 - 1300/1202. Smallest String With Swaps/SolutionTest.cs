using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SmallestStringWithSwaps
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"dcab", "[[0,3],[1,2]]", "bacd"},
            new object[] {"dcab", "[[0,3],[1,2],[0,2]]", "abcd"},
            new object[] {"cba", "[[0,1],[1,2]]", "abc"},
            new object[] {"dcab", "[[3,0],[2,1],[2,0]]", "abcd"},
            new object[] {"udyyek", "[[3,3],[3,0],[5,1],[3,1],[3,4],[3,5]]", "deykuy"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string pairsStr, string expected)
        {
            var pairs = ArrayHelper.MatrixFromString<int>(pairsStr);

            var sol = new Solution();
            var res = sol.SmallestStringWithSwaps(s, pairs);

            Assert.AreEqual(expected, res);
        }
    }
}