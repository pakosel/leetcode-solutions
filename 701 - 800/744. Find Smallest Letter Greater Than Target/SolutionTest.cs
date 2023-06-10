using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindSmallestLetterGreaterThanTarget
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[c,f,j]", 'a', 'c'},
            new object[] {"[c,f,j]", 'c', 'f'},
            new object[] {"[x,x,y,y]", 'z', 'x'},
            new object[] {"[c,f,j]", 'z', 'c'},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string lettersStr, char target, char expected)
        {
            var letters = ArrayHelper.ArrayFromString<char>(lettersStr);

            var sol = new Solution();
            var res = sol.NextGreatestLetter(letters, target);

            Assert.AreEqual(expected, res);
        }
    }
}