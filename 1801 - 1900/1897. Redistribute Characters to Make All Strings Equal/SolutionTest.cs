using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RedistributeCharactersToMakeAllStringsEqual
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[abc,aabc,bc]", true},
            new object[] {"[ab,a]", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string wordsStr, bool expected)
        {
            var words = ArrayHelper.ArrayFromString<string>(wordsStr);

            var sol = new Solution();
            var res = sol.MakeEqual(words);

            Assert.AreEqual(expected, res);
        }
    }
}