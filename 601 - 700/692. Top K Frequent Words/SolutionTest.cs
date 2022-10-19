using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TopKFrequentWords
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[i,love,leetcode,i,love,coding]", 2, "[i,love]"},
            new object[] {"[the,day,is,sunny,the,the,the,sunny,is,is]", 4, "[the,is,sunny,day]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string wordsStr, int k, string expectedStr)
        {
            var words = ArrayHelper.ArrayFromString<string>(wordsStr);
            var expected = ArrayHelper.ArrayFromString<string>(expectedStr);

            var sol = new Solution();
            var res = sol.TopKFrequent(words, k);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}