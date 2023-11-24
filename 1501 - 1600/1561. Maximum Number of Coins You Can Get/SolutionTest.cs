using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumNumberOfCoinsYouCanGet
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2,4,1,2,7,8]", 9},
            new object[] {"[2,4,5]", 4},
            new object[] {"[9,8,7,6,5,1,2,3,4]", 18},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string pilesStr, int expected)
        {
            var piles = ArrayHelper.ArrayFromString<int>(pilesStr);

            var sol = new Solution();
            var res = sol.MaxCoins(piles);

            Assert.AreEqual(expected, res);
        }
    }
}