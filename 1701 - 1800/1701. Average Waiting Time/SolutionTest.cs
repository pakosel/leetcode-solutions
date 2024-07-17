using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace AverageWaitingTime
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,2],[2,5],[4,3]]", 5.00000},
            new object[] {"[[5,2],[5,4],[10,3],[20,1]]", 3.25000},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string customersStr, double expected)
        {
            var customers = ArrayHelper.MatrixFromString<int>(customersStr);

            var sol = new Solution();
            var res = sol.AverageWaitingTime(customers);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}