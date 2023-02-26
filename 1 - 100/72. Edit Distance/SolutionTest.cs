using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace EditDistance
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"", "", 0},
            new object[] {"", "ros", 3},
            new object[] {"a", "", 1},
            new object[] {"aa", "aa", 0},
            new object[] {"aa", "a", 1},
            new object[] {"aa", "bb", 2},
            new object[] {"horse", "ros", 3},
            new object[] {"intention", "execution", 5},
            new object[] {"aaca", "aaaawaa", 4},
            new object[] {"zoologicoarchaeologist", "zoogeologist", 10},
            new object[] {"ooloarchaeoo", "oogeoo", 7},
            new object[] {"distance", "springbok", 9},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Memo(string word1, string word2, int expected)
        {
            var sol = new Solution_Memo();
            var res = sol.MinDistance(word1, word2);

            Assert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Example(string word1, string word2, int expected)
        {
            var sol = new Solution();
            var res = sol.MinDistance(word1, word2);

            Assert.AreEqual(expected, res);
        }
    }
}