using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ReverseWordsInStringIII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc"},
            new object[] {"God Ding", "doG gniD"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string expected)
        {
            var sol = new Solution();
            var res = sol.ReverseWords(s);

            Assert.AreEqual(expected, res);
        }
    }
}