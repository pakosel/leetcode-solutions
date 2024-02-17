using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindWordsThatCanBeFormedByCharacters
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[cat,bt,hat,tree]", "atach", 6},
            new object[] {"[hello,world,leetcode]", "welldonehoneyr", 10},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string wordsStr, string chars, int expected)
        {
            var words = ArrayHelper.ArrayFromString<string>(wordsStr);

            var sol = new Solution();
            var res = sol.CountCharacters(words, chars);

            Assert.That(expected == res);
        }
    }
}