using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SortVowelsInString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"lEetcOde", "lEOtcede"},
            new object[] {"lYmpH", "lYmpH"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, string expected)
        {
            var sol = new Solution();
            var res = sol.SortVowels(s);

            Assert.That(expected == res);
        }
    }
}