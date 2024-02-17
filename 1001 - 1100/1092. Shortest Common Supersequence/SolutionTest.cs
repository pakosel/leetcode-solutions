using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace ShortestCommonSubsequence
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "abac", "cab", "cabac" },
            new object[] { "a", "c", "ca" },
            new object[] { "ba", "a", "ba" },
            new object[] { "abc", "abc" , "abc" },
            new object[] { "abac", "caaad", "caabadc" },
            new object[] { "abaaaaac", "caaad", "cabaadaaac" },
            new object[] { "euazbipzncptldueeuechubrcourfpftcebikrxhybkymimgvldiwqvkszfycvqyvtiwfckexmowcxztkfyzqovbtmzpxojfofbvwnncajvrvdbvjhcrameamcfmcoxryjukhpljwszknhiypvyskmsujkuggpztltpgoczafmfelahqwjbhxtjmebnymdyxoeodqmvkxittxjnlltmoobsgzdfhismogqfpfhvqn", "aaakhjsdfljkxxxxxlkjlkjlkjlkjbbb" , "aaeuazbipzncptldueeuechubrcourfpftcebikrxhjsybkymimgvldiwqvkszfljycvqyvtiwfckxexmowcxztkfyzqovbtmzpxojfofbvwnncajvrvdbvjhcrameamcfmcoxlkryjlukjhpljwszknhiypvyskmsujlkuggpztltpgoczafmfelahqwjbhxtjmebnymdyxoeodqmvkxittxjnlltmoobsgzdfhismogqfpfhvqn" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string str1, string str2, string expected)
        {
            var sol = new Solution();
            var res = sol.ShortestCommonSupersequence(str1, str2);

            Assert.That(expected == res);
        }
    }
}