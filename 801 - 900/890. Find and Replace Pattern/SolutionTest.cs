using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindAndReplacePattern
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[abc,deq,mee,aqq,dkd,ccc]", "abb", "[mee,aqq]"},
            new object[] {"[a,b,c]", "a", "[a,b,c]"},
            new object[] {"[abc,deq,mee,aqq,dkd,ccc]", "xyz", "[abc,deq]"},
            new object[] {"[abc,deq,mee,aqq,dkd,ccc]", "ccc", "[ccc]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string wordsStr, string pattern, string expectedStr)
        {
            var words = ArrayHelper.ArrayFromString<string>(wordsStr);
            var expected = ArrayHelper.ArrayFromString<string>(expectedStr);

            var sol = new Solution();
            var res = sol.FindAndReplacePattern(words, pattern);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}