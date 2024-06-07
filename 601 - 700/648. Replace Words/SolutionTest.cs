using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ReplaceWords
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[cat,bat,rat]", "the cattle was rattled by the battery", "the cat was rat by the bat"},
            new object[] {"[a,b,c]", "aadsfasf absbs bbab cadsfafs", "a a b c"},
            new object[] {"[catt,cat,bat,rat]", "the cattle was rattled by the battery", "the cat was rat by the bat"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string dictionaryStr, string sentence, string expected)
        {
            var dictionary = ArrayHelper.ArrayFromString<string>(dictionaryStr);

            var sol = new Solution();
            var res = sol.ReplaceWords(dictionary, sentence);

            Assert.That(expected, Is.EqualTo(res));
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericHashSet(string dictionaryStr, string sentence, string expected)
        {
            var dictionary = ArrayHelper.ArrayFromString<string>(dictionaryStr);

            var sol = new Solution_HashSet();
            var res = sol.ReplaceWords(dictionary, sentence);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}