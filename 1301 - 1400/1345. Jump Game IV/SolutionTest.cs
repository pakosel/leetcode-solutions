using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace JumpGameIV

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[7]", 0},
            new object[] {"[100,-23,-23,404,100,23,23,23,3,404]", 3},
            new object[] {"[7,6,9,6,9,6,9,7]", 1},
            new object[] {"[1,2]", 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string arrStr, int expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.MinJumps(arr);

            Assert.AreEqual(expected, res);
        }
    }
}