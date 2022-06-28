using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumDeletionsToMakeCharacterFrequenciesUnique
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"aab", 0},
            new object[] {"aaabbbcc", 2},
            new object[] {"ceabaacb", 2},
            new object[] {"bbcebab", 2},
            new object[] {"aaaaaaaaaaabbbbbbbbbbccccccccccddddddddddeeeeeeeeeeffffffffffgggggggggghhhhhhhhhh", 21},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.MinDeletions(s);

            Assert.AreEqual(expected, res);
        }
    }
}