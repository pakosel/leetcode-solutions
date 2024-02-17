using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace DetectCapital
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "USA", true },
            new object[] { "flag", true },
            new object[] { "Flag", true },
            new object[] { "FlagG", false },
            new object[] { "a", true },
            new object[] { "A", true },
            new object[] { "HelloWorld", false },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string word, bool expected)
        {
            var sol = new Solution();
            var res = sol.DetectCapitalUse(word);

            Assert.That(expected == res);
        }
    }
}