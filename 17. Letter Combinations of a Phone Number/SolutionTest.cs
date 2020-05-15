using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace LetterCombinationsPhoneNumber
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"", new string[] {}},
            new object[] {"1", new string[] {}},
            new object[] {"2", new string[] {"a", "b", "c"}},
            new object[] {"23", new string[] {"ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"}},
            new object[] {"12", new string[] {}},
            new object[] {"31", new string[] {}},
            new object[] {"234", new string[] {"adg","adh","adi","aeg","aeh","aei","afg","afh","afi","bdg","bdh","bdi","beg","beh","bei","bfg","bfh","bfi","cdg","cdh","cdi","ceg","ceh","cei","cfg","cfh","cfi"}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string digits, IList<string> expected)
        {
            var sol = new Solution();
            var res = sol.LetterCombinations(digits);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}