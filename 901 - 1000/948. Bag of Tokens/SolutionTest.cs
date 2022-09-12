using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BagOfTokens
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[100]", 50, 0},        
            new object[] {"[100,200]", 150, 1},        
            new object[] {"[100,200,300,400]", 200, 2},        
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string tokensStr, int power, int expected)
        {
            var tokens = ArrayHelper.ArrayFromString<int>(tokensStr);

            var sol = new Solution();
            var res = sol.BagOfTokensScore(tokens, power);

            Assert.AreEqual(expected, res);
        }
    }
}