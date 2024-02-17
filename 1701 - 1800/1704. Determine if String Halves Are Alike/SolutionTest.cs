using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DetermineIfStringHalvesAreAlike
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"book", true},
            new object[] {"textbook", false},
            new object[] {"aa", true},
            new object[] {"ab", false},
            new object[] {"aA", true},
            new object[] {"Aa", true},
            new object[] {"AbBa", true},
            new object[] {"AE", true},
            new object[] {"AbCdEfGh", true},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic24(string s, bool expected)
        {
            var sol = new Solution_2024();
            var res = sol.HalvesAreAlike(s);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, bool expected)
        {
            var sol = new Solution();
            var res = sol.HalvesAreAlike(s);

            Assert.That(expected == res);
        }
    }
}