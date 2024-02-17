using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NetworkDelayTime
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[1,2,1],[2,1,1]]", 2, 1, 1},
            new object[] {"[[2,1,1],[2,3,1],[3,4,1]]", 4, 2, 2},
            new object[] {"[[3,5,78],[2,1,1],[1,3,0],[4,3,59],[5,3,85],[5,2,22],[2,4,23],[1,4,43],[4,5,75],[5,1,15],[1,5,91],[4,1,16],[3,2,98],[3,4,22],[5,4,31],[1,2,0],[2,5,4],[4,2,51],[3,1,36],[2,3,59]]", 5, 5, 31},
            new object[] {"[[2,4,10],[5,2,38],[3,4,33],[4,2,76],[3,2,64],[1,5,54],[1,4,98],[2,3,61],[2,1,0],[3,5,77],[5,1,34],[3,1,79],[5,3,2],[1,2,59],[4,3,46],[5,4,44],[2,5,89],[4,5,21],[1,3,86],[4,1,95]]", 5, 1, 69},
            new object[] {"[[4,3,76],[1,4,70],[1,3,37],[1,2,53],[3,2,66],[3,4,22],[5,4,52],[2,1,23],[5,1,27],[4,5,88],[5,2,26],[2,4,41],[4,2,66],[4,1,93],[3,5,78],[2,5,9],[5,3,50],[3,1,17],[1,5,12],[2,3,87]]", 5, 5, 52},
            new object[] {"[[1,2,1],[2,3,7],[1,3,4],[2,1,2]]", 3, 2, 6},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string timesStr, int n, int k, int expected)
        {
            var times = ArrayHelper.MatrixFromString<int>(timesStr);

            var sol = new Solution();
            var res = sol.NetworkDelayTime(times, n, k);

            Assert.That(expected == res);
        }
    }
}