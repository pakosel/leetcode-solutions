using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumPointsYouCanObtainFromCards
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3,4,5,6,1]", 3, 12},
            new object[] {"[2,2,2]", 2, 4},
            new object[] {"[9,7,7,9,7,7,9]", 7, 55},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string cardsStr, int k, int expected)
        {
            var cardPoints = ArrayHelper.ArrayFromString<int>(cardsStr);

            var sol = new Solution();
            var res = sol.MaxScore(cardPoints, k);

            Assert.That(expected == res);
        }
    }
}