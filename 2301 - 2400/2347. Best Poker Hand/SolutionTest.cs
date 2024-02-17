using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BestPokerHand
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[13,2,3,1,9]", "[a,a,a,a,a]", "Flush"},
            new object[] {"[4,4,2,4,4]", "[d,a,a,b,c]", "Three of a Kind"},
            new object[] {"[10,10,2,12,9]", "[a,b,c,a,d]", "Pair"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string ranksStr, string suitsStr, string expected)
        {
            var ranks = ArrayHelper.ArrayFromString<int>(ranksStr);
            var suits = ArrayHelper.ArrayFromString<char>(suitsStr);
            
            var sol = new Solution();
            var res = sol.BestHand(ranks, suits);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}