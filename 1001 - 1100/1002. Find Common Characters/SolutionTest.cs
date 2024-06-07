using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindCommonCharacters
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[bella,label,roller]", "[e,l,l]"},
            new object[] {"[cool,lock,cook]", "[c,o]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Memoization(string wordsStr, string expectedStr)
        {
            var words = ArrayHelper.ArrayFromString<string>(wordsStr);
            var expected = ArrayHelper.ArrayFromString<string>(expectedStr);

            var sol = new Solution();
            var res = sol.CommonChars(words);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}