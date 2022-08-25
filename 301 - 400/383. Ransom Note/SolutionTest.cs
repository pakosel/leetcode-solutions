using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace RansomNote
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"a", "b", false},
            new object[] {"aa", "ab", false},
            new object[] {"aa", "aab", true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string ransomNote, string magazine, bool expected)
        {
            var sol = new Solution();
            var res = sol.CanConstruct(ransomNote, magazine);

            Assert.AreEqual(expected, res);
        }
    }
}