using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ReversePrefixOfWord
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"abcdefd", 'd', "dcbaefd"},
            new object[] {"xyxzxe", 'z', "zxyxxe"},
            new object[] {"abcd", 'z', "abcd"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string word, char ch, string expected)
        {
            var sol = new Solution();
            var res = sol.ReversePrefix(word, ch);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}