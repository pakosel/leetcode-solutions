using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumPerformanceOfTeam
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {6, "[2,10,3,1,5,8]", "[5,4,3,9,7,2]", 2, 60},
            new object[] {6, "[2,10,3,1,5,8]", "[5,4,3,9,7,2]", 3 , 68},
            new object[] {6, "[2,10,3,1,5,8]", "[5,4,3,9,7,2]", 4, 72},
            new object[] {6, "[2,10,3,1,5,20]", "[5,4,3,9,7,2]", 3, 70},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int n, string speedStr, string efficiencyStr, int k, int expected)
        {
            var speed = ArrayHelper.ArrayFromString<int>(speedStr);
            var efficiency = ArrayHelper.ArrayFromString<int>(efficiencyStr);
            ClassicAssert.AreEqual(n, efficiency.Length);
            ClassicAssert.AreEqual(speed.Length, efficiency.Length);

            var sol = new Solution();
            var res = sol.MaxPerformance(n, speed, efficiency, k);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}