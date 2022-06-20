using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ShortEncodingOfWords
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new string[] {"t"}, 2},
            new object[] {new string[] {"time", "me", "bell"}, 10},
            new object[] {new string[] {"time","bell","me","timing","sorting","ping","ting","ing","x","xy"}, 35},
            new object[] {new string[] {"time","bell","me","timing","sorting","ping","ting","ing","x","xy","l","t","sorting","nor","xor"}, 45},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Trie(string[] words, int expected)
        {
            var sol = new Solution_Trie();
            var res = sol.MinimumLengthEncoding(words);

            Assert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] words, int expected)
        {
            var sol = new Solution();
            var res = sol.MinimumLengthEncoding(words);

            Assert.AreEqual(expected, res);
        }
    }
}