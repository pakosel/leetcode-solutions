using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumIceCreamBars
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,3,2,4,1]", 7, 4},
            new object[] {"[10,6,8,7,7,8]", 5, 0},
            new object[] {"[1,6,3,1,2,5]", 20, 6},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string costsStr, int coins, int expected)
        {
            var costs = ArrayHelper.ArrayFromString<int>(costsStr);

            var sol = new Solution();
            var res = sol.MaxIceCream(costs, coins);

            Assert.That(expected == res);
        }
    }
}