using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CapitalizeTheTitle
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"capiTalIze tHe titLe", "Capitalize The Title"},
            new object[] {"First leTTeR of EACH Word", "First Letter of Each Word"},
            new object[] {"i lOve leetcode", "i Love Leetcode"},
            new object[] {"capiTalIze tHe titLe", "Capitalize The Title"},
            new object[] {"a", "a"},
            new object[] {"A", "a"},
            new object[] {"Ab", "ab"},
            new object[] {"Abc", "Abc"},
            new object[] {"abc d", "Abc d"},
            new object[] {"abc de", "Abc de"},
            new object[] {"abc def", "Abc Def"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string title, string expected)
        {
            var sol = new Solution();
            var res = sol.CapitalizeTitle(title);

            Assert.AreEqual(res, expected);
        }
    }
}