using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SearchSuggestionsSystem
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[mobile,mouse,moneypot,monitor,mousepad]", "mouse", "[[mobile,moneypot,monitor],[mobile,moneypot,monitor],[mouse,mousepad],[mouse,mousepad],[mouse,mousepad]]"},
            new object[] {"[havana]", "havana", "[[havana],[havana],[havana],[havana],[havana],[havana]]"},
            new object[] {"[bags,baggage,banner,box,cloths]", "bags", "[[baggage,bags,banner],[baggage,bags,banner],[baggage,bags],[bags]]"},
            new object[] {"[mobile,mouse,moneypot,monitor,mousepad]", "xyz", "[[],[],[]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string productsStr, string searchWord, string expectedStr)
        {
            var products = ArrayHelper.ArrayFromString<string>(productsStr);
            var expected = ArrayHelper.MatrixFromString<string>(expectedStr);
            Assert.AreEqual(searchWord.Length, expected.Length);

            var sol = new Solution();
            var res = sol.SuggestedProducts(products, searchWord);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}