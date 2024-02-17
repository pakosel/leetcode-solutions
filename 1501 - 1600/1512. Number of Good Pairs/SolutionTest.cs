using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOfGoodPairs
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3,1,1,3]", 4},
            new object[] {"[1,1,1,1]", 6},
            new object[] {"[1,2,3]", 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.NumIdenticalPairs(nums);

            Assert.That(expected == res);
        }
    }
}