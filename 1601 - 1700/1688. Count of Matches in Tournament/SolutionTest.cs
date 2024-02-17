using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountOfMatchesInTournament
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {7, 6},
            new object[] {14, 13},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.NumberOfMatches(n);

            Assert.That(expected == res);
        }
    }
}