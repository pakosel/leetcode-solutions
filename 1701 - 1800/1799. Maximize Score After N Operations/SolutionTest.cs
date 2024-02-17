using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximizeScoreAfterNOperations
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2]", 1},
            new object[] {"[3,4,6,8]", 11},
            new object[] {"[1,2,3,4,5,6]", 14},
            new object[] {"[267439,274943,271231,787469,818683,952649,856147,819991,379837,135719,968147,211927,169241,548579]", 28},
            new object[] {"[109497,983516,698308,409009,310455,528595,524079,18036,341150,641864,913962,421869,943382,295019]", 527},
            new object[] {"[109497,983516,698308,409009,310455,528595,524079,18036,913962,421869,943382,295019]", 433},
            new object[] {"[109497,409009,310455,528595,524079,18036]", 38},
            new object[] {"[865,195,397,452,154,628,936,402,596,242,10,699,195,595]", 1564},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.MaxScore(nums);

            Assert.That(expected == res);
        }
    }
}