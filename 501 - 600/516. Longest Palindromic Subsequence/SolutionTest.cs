using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace LongestPalindromicSubsequence
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "a", 1 },
            new object[] { "aa", 2 },
            new object[] { "bbbab", 4 },
            new object[] { "bxbbab", 4 },
            new object[] { "cbbd", 2 },
            new object[] { "aaakhjsdfljkxxxxxlkjlkjlkjlkjbbb", 15 },
            new object[] { "euazbipzncptldueeuechubrcourfpftcebikrxhybkymimgvldiwqvkszfycvqyvtiwfckexmowcxztkfyzqovbtmzpxojfofbvwnncajvrvdbvjhcrameamcfmcoxryjukhpljwszknhiypvyskmsujkuggpztltpgoczafmfelahqwjbhxtjmebnymdyxoeodqmvkxittxjnlltmoobsgzdfhismogqfpfhvqnxeuosjqqalvwhsidgiavcatjjgeztrjuoixxxoznklcxolgpuktirmduxdywwlbikaqkqajzbsjvdgjcnbtfksqhquiwnwflkldgdrqrnwmshdpykicozfowmumzeuznolmgjlltypyufpzjpuvucmesnnrwppheizkapovoloneaxpfinaontwtdqsdvzmqlgkdxlbeguackbdkftzbnynmcejtwudocemcfnuzbttcoew", 159 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.LongestPalindromeSubseq(s);

            Assert.That(expected == res);
        }
        
        [Test]
        [TestCaseSource("testCases")]
        public void Test_Memoization(string s, int expected)
        {
            var sol = new SolutionMemoization();
            var res = sol.LongestPalindromeSubseq(s);

            Assert.That(expected == res);
        }
    }
}