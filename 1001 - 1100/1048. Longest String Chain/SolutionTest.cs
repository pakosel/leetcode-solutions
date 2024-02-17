using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LongestStringChain
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new string[] {"a","b","ba","bca","bda","bdca"}, 4},
            new object[] {new string[] {"xbc","pcxbcf","xb","cxbc","pcxbc"}, 5},
            new object[] {new string[] {"abcd","dbqca"}, 1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] words, int expected)
        {
            var sol = new Solution();
            var res = sol.LongestStrChain(words);

            Assert.That(expected == res);
        }
    }
}