using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TaskScheduler
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[A,A,A,B,B,B]", 2, 8},
            new object[] {"[A,C,A,B,D,B]", 1, 6},
            new object[] {"[A,A,A,B,B,B]", 3, 10},
            new object[] {"[A]", 1, 1},
            new object[] {"[A]", 2, 1},
            new object[] {"[A,B]", 1, 2},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string tasksStr, int n, int expected)
        {
            var tasks = ArrayHelper.ArrayFromString<char>(tasksStr);

            var sol = new Solution();
            var res = sol.LeastInterval(tasks, n);

            Assert.That(expected == res);
        }
    }
}