using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LengthOfLastWord
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"a", 1},
            new object[] {"Hello World", 5},
            new object[] {"   fly me   to   the moon  ", 4},
            new object[] {"luffy is still joyboy", 6},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.LengthOfLastWord(s);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}