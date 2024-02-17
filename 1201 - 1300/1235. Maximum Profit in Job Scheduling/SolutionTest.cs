using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumProfitInJobScheduling
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3,3]","[3,4,5,6]","[50,10,40,70]",120},
            new object[] {"[1,2,3,4,6]","[3,5,10,6,9]","[20,20,100,70,60]",150},
            new object[] {"[1,1,1]","[2,3,4]","[5,6,4]",6},
            new object[] {"[1,2,3,3]","[3,4,5,1000000000]","[50,10,40,70]",120},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string startTimeStr, string endTimeStr, string profitStr, int expected)
        {
            var startTime = ArrayHelper.ArrayFromString<int>(startTimeStr);
            var endTime = ArrayHelper.ArrayFromString<int>(endTimeStr);
            var profit = ArrayHelper.ArrayFromString<int>(profitStr);

            var sol = new Solution();
            var res = sol.JobScheduling(startTime, endTime, profit);

            Assert.That(expected == res);
        }
    }
}