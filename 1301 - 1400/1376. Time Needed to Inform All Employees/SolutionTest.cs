using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TimeNeededToInformAllEmployees
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, 0, "[-1]", "[0]", 0},
            new object[] {6, 2, "[2,2,-1,2,2,2]", "[0,0,1,0,0,0]", 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int n, int headID, string managerStr, string informTimeStr, int expected)
        {
            var manager = ArrayHelper.ArrayFromString<int>(managerStr);
            var informTime = ArrayHelper.ArrayFromString<int>(informTimeStr);

            var sol = new Solution();
            var res = sol.NumOfMinutes(n, headID, manager, informTime);

            Assert.That(expected == res);
        }
    }
}