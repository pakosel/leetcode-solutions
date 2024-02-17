using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PercentageOfLetterInString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"foobar", 'o', 33},
            new object[] {"jjjj", 'k', 0},
            new object[] {"f", 'f', 100},
            new object[] {"jkjjj", 'k', 20},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, char letter, int expected)
        {
            var sol = new Solution();
            var res = sol.PercentageLetter(s, letter);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}