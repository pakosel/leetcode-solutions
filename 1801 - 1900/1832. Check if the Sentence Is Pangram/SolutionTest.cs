using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CheckIfTheSentenceIsPangram
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"thequickbrownfoxjumpsoverthelazydog", true},
            new object[] {"leetcode", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string sentence, bool expected)
        {
            var sol = new Solution();
            var res = sol.CheckIfPangram(sentence);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}