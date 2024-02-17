using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumGeneticMutation
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"AACCGGTT", "AACCGGTA", "[AACCGGTA]", 1},
            new object[] {"AACCGGTT", "AAACGGTA", "[AACCGGTA,AACCGCTA,AAACGGTA]", 2},
            new object[] {"AAAAACCC", "AACCCCCC", "[AAAACCCC,AAACCCCC,AACCCCCC]", 3},
            new object[] {"AACCGGTT", "TTTTCTTA", "[AACCGGTA,AACCGTTT,AACCGTTA,ATCCGTTA,TACCGTTA,TTCCGTTA,TTTTCTTA,TTTCGTTA,TTTTGTTA]", 7},
            new object[] {"AAAAAAAA", "CCCCCCCC", "[AAAAAAAA,AAAAAAAC,AAAAAACC,AAAAACCC,AAAACCCC,AACACCCC,ACCACCCC,ACCCCCCC,CCCCCCCA]", -1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string start, string end, string bankStr, int expected)
        {
            var bank = ArrayHelper.ArrayFromString<string>(bankStr);

            var sol = new Solution();
            var res = sol.MinMutation(start, end, bank);

            Assert.That(expected == res);
        }
    }
}