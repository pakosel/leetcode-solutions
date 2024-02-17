using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace StringCompression
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[a]", "[a]"},
            new object[] {"[a,a]", "[a,2]"},
            new object[] {"[a,a,b,b,c,c,c]", "[a,2,b,2,c,3]"},
            new object[] {"[a,b,b,b,b,b,b,b,b,b,b,b,b]", "[a,b,1,2]"},
            new object[] {"[o,o,o,o,o,o,o,o,o,o]", "[o,1,0]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string charsStr, string expectedStr)
        {
            var chars = ArrayHelper.ArrayFromString<char>(charsStr);
            var expected = ArrayHelper.ArrayFromString<char>(expectedStr);

            var sol = new Solution();
            var res = sol.Compress(chars);

            Assert.That(res == expected.Length);
            CollectionAssert.AreEquivalent(chars.Take(res), expected);
        }
    }
}