using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MergeStringsAlternately
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"abc", "pqr", "apbqcr"},
            new object[] {"ab", "pqrs", "apbqrs"},
            new object[] {"abcd", "pq", "apbqcd"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string word1, string word2, string expected)
        {
            var sol = new Solution();
            var res = sol.MergeAlternately(word1, word2);

            Assert.AreEqual(expected, res);
        }
    }
}