using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CheckIfTwoStringArraysAreEquivalent
{
    [TestFixture]
    public class CheckIfTwoStringArraysAreEquivalent
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[ab,c]", "[a,bc]", true},
            new object[] {"[a,cb]", "[ab,c]", false},
            new object[] {"[abc,d,defg]", "[abcddefg]", true},
            new object[] {"[abc,defg,d]","[abcddefg]", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string word1Str, string word2Str, bool expected)
        {
            var word1 = ArrayHelper.ArrayFromString<string>(word1Str);
            var word2 = ArrayHelper.ArrayFromString<string>(word2Str);

            var sol = new Solution();
            var res = sol.ArrayStringsAreEqual(word1, word2);

            ClassicAssert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericSB(string word1Str, string word2Str, bool expected)
        {
            var word1 = ArrayHelper.ArrayFromString<string>(word1Str);
            var word2 = ArrayHelper.ArrayFromString<string>(word2Str);

            var sol = new SolutionSB();
            var res = sol.ArrayStringsAreEqual(word1, word2);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}