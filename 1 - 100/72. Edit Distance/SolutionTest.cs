using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace EditDistance
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("", "", 0)]
        [TestCase("", "ros", 3)]
        [TestCase("a", "", 1)]
        [TestCase("aa", "aa", 0)]
        [TestCase("aa", "a", 1)]
        [TestCase("aa", "bb", 2)]
        [TestCase("horse", "ros", 3)]
        [TestCase("intention", "execution", 5)]
        [TestCase("aaca", "aaaawaa", 4)]
        [TestCase("zoologicoarchaeologist", "zoogeologist", 10)]
        [TestCase("ooloarchaeoo", "oogeoo", 7)]
        [TestCase("distance", "springbok", 9)]
        public void Test_Example(string word1, string word2, int expected)
        {
            var sol = new Solution();
            var ret = sol.MinDistance(word1, word2);

            Assert.AreEqual(ret, expected);
        }
    }
}