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
        };

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