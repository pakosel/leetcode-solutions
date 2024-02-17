using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace VerifyingAlienDictionary
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new string[] {"app"}, "abcdefghijklmnopqrstuvwxyz", true },
            new object[] { new string[] {"hello","leetcode"}, "hlabcdefgijkmnopqrstuvwxyz", true },
            new object[] { new string[] {"word","world","row"}, "worldabcefghijkmnpqstuvxyz", false },
            new object[] { new string[] {"apple","app"}, "abcdefghijklmnopqrstuvwxyz", false },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic22(string[] words, string order, bool expected)
        {
            var sol = new Solution_2022();
            var res = sol.IsAlienSorted(words, order);

            ClassicAssert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] words, string order, bool expected)
        {
            var sol = new Solution();
            var res = sol.IsAlienSorted(words, order);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}