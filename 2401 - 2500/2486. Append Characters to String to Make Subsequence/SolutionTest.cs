using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace AppendCharactersToStringToMakeSubsequence
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"coaching", "coding", 4},
            new object[] {"abcde", "a", 0},
            new object[] {"z", "abcde", 5},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, string t, int expected)
        {
            var sol = new Solution();
            var res = sol.AppendCharacters(s, t);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}