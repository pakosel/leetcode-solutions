using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace LongestCommonSubsequence
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "abcde", "ace" , 3 },
            new object[] { "abc", "abc" , 3 },
            new object[] { "abc", "def" , 0 },
            new object[] { "eua", "aaa" , 1 },
            new object[] { "euazbipzncptldueeuechubrcourfpftcebikrxhybkymimgvldiwqvkszfycvqyvtiwfckexmowcxztkfyzqovbtmzpxojfofbvwnncajvrvdbvjhcrameamcfmcoxryjukhpljwszknhiypvyskmsujkuggpztltpgoczafmfelahqwjbhxtjmebnymdyxoeodqmvkxittxjnlltmoobsgzdfhismogqfpfhvqn", "aaakhjsdfljkxxxxxlkjlkjlkjlkjbbb" , 20 },
            
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string text1, string text2, int expected)
        {
            var sol = new Solution();
            var res = sol.LongestCommonSubsequence(text1, text2);

            Assert.AreEqual(res, expected);
        }
    }
}