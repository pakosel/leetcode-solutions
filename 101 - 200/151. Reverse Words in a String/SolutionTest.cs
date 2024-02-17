using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace ReverseWordsInString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "", "" },
            new object[] { "a", "a" },
            new object[] { "   a   ", "a" },
            new object[] { "a b", "b a" },
            new object[] { "a    b", "b a" },
            new object[] { "    a    b   ", "b a" },
            new object[] { "the sky is blue", "blue is sky the" },
            new object[] { "  hello world!  ", "world! hello" },
            new object[] { "a good   example", "example good a" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Solution(string s, string expected)
        {
            var sol = new Solution();
            var ret = sol.ReverseWords(s);

            Assert.That(expected == ret);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Solution_SemiManual(string s, string expected)
        {
            var sol = new Solution_SemiManual();
            var ret = sol.ReverseWords(s);

            Assert.That(expected == ret);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Solution_Manual(string s, string expected)
        {
            var sol = new Solution_FullManual();
            var ret = sol.ReverseWords(s);

            Assert.That(expected == ret);
        }
    }
}