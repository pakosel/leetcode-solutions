using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace ImplementMagicDictionary
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new string[] {"hello", "leetcode"}, new string[] {"hello", "hhllo", "hell", "leetcoded"}, new bool[] {false, true, false, false} },
            new object[] { new string[] {"null"}, new string[] {"hello", "hhllo", "hell", "leetcoded"}, new bool[] {false, false, false, false} },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] dict, string[] words, bool[] expected)
        {
            var sol = new MagicDictionary();
            sol.BuildDict(dict);
            for(int i=0; i<words.Length; i++)
                Assert.AreEqual(sol.Search(words[i]), expected[i]);
        }
    }
}