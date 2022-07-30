using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace WordSubsets
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[amazon,apple,facebook,google,leetcode]", "[e,o]", "[facebook,google,leetcode]"},
            new object[] {"[amazon,apple,facebook,google,leetcode]", "[l,e]", "[apple,google,leetcode]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string words1Str, string words2Str, string expectedStr)
        {
            var words1 = ArrayHelper.ArrayFromString<string>(words1Str);
            var words2 = ArrayHelper.ArrayFromString<string>(words2Str);
            var expected = ArrayHelper.ArrayFromString<string>(expectedStr);

            var sol = new Solution();
            var res = sol.WordSubsets(words1, words2);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}