using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CrawlerLogFolder
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[d1/,d2/,../,d21/,./]", 2},
            new object[] {"[d1/,d2/,./,d3/,../,d31/]", 3},
            new object[] {"[d1/,../,../,../]", 0},
            new object[] {"[d1/,d2/,../,d21/,./,../,../,../,../,../]", 0},
            
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string logsStr, int expected)
        {
            var logs = ArrayHelper.ArrayFromString<string>(logsStr);

            var sol = new Solution();
            var res = sol.MinOperations(logs);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}