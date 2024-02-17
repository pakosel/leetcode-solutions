using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumRoundsToCompleteAllTasks
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2,2,3,3,2,4,4,4,4,4]", 4},
            new object[] {"[2,3,3]", -1},
            new object[] {"[2,2,3,3]", 2},
            new object[] {"[2,3,3,2,4,2,4,4,4,2,4]", 5},
            new object[] {"[2,2,2,2,2,2,2,2,2,2,2,7,7,7,7,7,7,7,7,7,7,3,7,7,7,7,3,7,7,7,7,7,7,7,7]", 13},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string tasksStr, int expected)
        {
            var tasks = ArrayHelper.ArrayFromString<int>(tasksStr);

            var sol = new Solution();
            var res = sol.MinimumRounds(tasks);

            Assert.That(expected == res);
        }
    }
}