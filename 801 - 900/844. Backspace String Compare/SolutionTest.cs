using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BackspaceStringCompare
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"ab#c", "ad#c", true},
            new object[] {"ab##", "c#d#", true},
            new object[] {"a#c", "b", false},
            new object[] {"y#fo##f", "y#f#o##f", true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string s, string t, bool expected)
        {
            var sol = new Solution();
            var res = sol.BackspaceCompare(s, t);

            Assert.That(expected == res);
        }
    }
}