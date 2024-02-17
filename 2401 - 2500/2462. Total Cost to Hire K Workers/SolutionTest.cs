using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TotalCostToHireKWorkers
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[17,12,10,2,7,2,11,20,8]", 3, 4, 11},
            new object[] {"[1,2,4,1]", 3, 3, 4},
            new object[] {"[1,2,3,2,7,2,11,20,8]", 8, 4, 36},
            new object[] {"[18,64,12,21,21,78,36,58,88,58,99,26,92,91,53,10,24,25,20,92,73,63,51,65,87,6,17,32,14,42,46,65,43,9,75]", 13, 23, 223},
            new object[] {"[18,64,12,21,21,78,36,1,88,58,99,26,92,91,53]", 3, 8, 31},
            new object[] {"[48]", 1, 1, 48},
            new object[] {"[2,1,2]", 1, 1, 2},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string costsStr, int k, int candidates, int expected)
        {
            var costs = ArrayHelper.ArrayFromString<int>(costsStr);
            
            var sol = new Solution();
            var res = sol.TotalCost(costs, k, candidates);

            Assert.That(expected == res);
        }
    }
}