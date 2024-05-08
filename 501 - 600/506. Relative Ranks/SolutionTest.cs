using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RelativeRanks
{
    [TestFixture]
    public class MaximumBinaryTree
    {
        private static readonly object[] testCases =
        {
            new object[] {"[5,4,3,2,1]", "[Gold Medal,Silver Medal,Bronze Medal,4,5]"},
            new object[] {"[10,3,8,9,4]", "[Gold Medal,5,Bronze Medal,Silver Medal,4]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string scoreStr, string expectedStr)
        {
            var score = ArrayHelper.ArrayFromString<int>(scoreStr);
            var expected = ArrayHelper.ArrayFromString<string>(expectedStr);

            var sol = new Solution();
            var res = sol.FindRelativeRanks(score);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}