using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindFirstPalindromicStringInTheArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[abc,car,ada,racecar,cool]", "ada"},
            new object[] {"[notapalindrome,racecar]", "racecar"},
            new object[] {"[def,ghi]", ""},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string wordsStr, string expected)
        {
            var words = ArrayHelper.ArrayFromString<string>(wordsStr);

            var sol = new Solution();
            var res = sol.FirstPalindrome(words);

            Assert.That(expected == res);
        }
    }
}