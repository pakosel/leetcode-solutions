using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RemovingStarsFromString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"leet**cod*e", "lecoe"},
            new object[] {"erase*****", ""},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, string expected)
        {
            var sol = new Solution();
            var res = sol.RemoveStars(s);

            Assert.That(expected == res);
        }
    }
}