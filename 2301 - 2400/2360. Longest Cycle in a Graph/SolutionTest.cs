using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LongestCycleInGraph
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[-1,-1]", -1},
            new object[] {"[3,3,4,2,3]", 3},
            new object[] {"[2,-1,3,1]", -1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string edgesStr, int expected)
        {
            var edges = ArrayHelper.ArrayFromString<int>(edgesStr);
            
            var sol = new Solution();
            var res = sol.LongestCycle(edges);

            Assert.That(expected == res);
        }
    }
}