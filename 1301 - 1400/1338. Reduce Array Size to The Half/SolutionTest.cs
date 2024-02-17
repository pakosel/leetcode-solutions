using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ReduceArraySizeToTheHalf
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,1]", 1},
            new object[] {"[2,1]", 1},
            new object[] {"[1,1,1,1,2,3,3,3,6,7,8,5]", 2},
            new object[] {"[4,4,1,1,1,1,2,3,3,3,6,7,8,5,9,9]", 3},
            new object[] {"[3,3,3,3,5,5,5,2,2,7]", 2},
            new object[] {"[7,7,7,7,7,7]", 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string arrStr, int expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.MinSetSize(arr);

            Assert.That(expected == res);
        }
    }
}