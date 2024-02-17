using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace RestoreIpAddresses
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"25525511135", new string[] {"255.255.11.135", "255.255.111.35"}},
            new object[] {"25525511135", new string[] {"255.255.111.35", "255.255.11.135"}},
            new object[] {"25525", new string[] {"2.5.5.25","2.5.52.5","2.55.2.5","25.5.2.5"}},
            new object[] {"111", new string[] {}},
            new object[] {"8888", new string[] {"8.8.8.8"}},
            new object[] {"01111", new string[] {"0.1.1.11","0.1.11.1","0.11.1.1"}},
            new object[] {"001111", new string[] {"0.0.1.111","0.0.11.11","0.0.111.1"}},
            new object[] {"0001111", new string[] {}},
            new object[] {"11111111111", new string[] {"11.111.111.111","111.11.111.111","111.111.11.111","111.111.111.11"}},
            new object[] {"111111111111", new string[] {"111.111.111.111"}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic2022(string input, string[] expected)
        {
            var sol = new Solution_2022();
            var res = sol.RestoreIpAddresses(input);

            CollectionAssert.AreEquivalent(res, expected);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string input, string[] expected)
        {
            var sol = new Solution();
            var res = sol.RestoreIpAddresses(input);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}