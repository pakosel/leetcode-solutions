using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountNumberConsistentStrings
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"x", new string[] {"x"}, 1},
            new object[] {"x", new string[] {"ad","bd"}, 0},
            new object[] {"ab", new string[] {"ad","bd","aaab","baa","badab"}, 2},
            new object[] {"abc", new string[] {"a","b","c","ab","ac","bc","abc"}, 7},
            new object[] {"cad", new string[] {"cc","acd","b","ba","bac","bad","ac","d"}, 4},
            
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string allowed, string[] words, int expected)
        {
            var sol = new Solution();
            var res = sol.CountConsistentStrings(allowed, words);

            Assert.That(expected == res);
        }
    }
}