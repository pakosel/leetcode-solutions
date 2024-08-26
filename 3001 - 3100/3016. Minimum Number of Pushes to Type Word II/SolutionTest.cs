using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumNumberOfPushesToTypeWordII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"abcde", 5},
            new object[] {"xyzxyzxyzxyz", 12},
            new object[] {"aabbccddeeffgghhiiiiii", 24},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string word, int expected)
        {
            var sol = new Solution();
            var res = sol.MinimumPushes(word);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}