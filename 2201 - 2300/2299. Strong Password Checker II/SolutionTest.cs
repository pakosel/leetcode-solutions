using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace StrongPasswordCheckerII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"IloveLe3tcode!", true},
            new object[] {"Me+You--IsMyDream", false},
            new object[] {"1aB!", false},
            new object[] {"1AaBb12!", true},
            new object[] {"1AaBb12@", true},
            new object[] {"1AaBb12#", true},
            new object[] {"1AaBb12$", true},
            new object[] {"1AaBb12%", true},
            new object[] {"1AaBb12^", true},
            new object[] {"1AaBb12&", true},
            new object[] {"1AaBb12*", true},
            new object[] {"1AaBb12(", true},
            new object[] {"1AaBb12)", true},
            new object[] {"1AaBb12-", true},
            new object[] {"1AaBb12+", true},
            new object[] {"a1A!A!A!", true},
            new object[] {"1Aaab12+", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Regex(string password, bool expected)
        {
            var sol = new SolutionRegex();
            var res = sol.StrongPasswordCheckerII(password);

            Assert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string password, bool expected)
        {
            var sol = new Solution();
            var res = sol.StrongPasswordCheckerII(password);

            Assert.AreEqual(expected, res);
        }
    }
}