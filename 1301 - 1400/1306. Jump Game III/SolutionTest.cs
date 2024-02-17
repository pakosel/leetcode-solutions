using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace JumpGameIII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0]", 0, true},
            new object[] {"[0,1]", 1, true},
            new object[] {"[0,2]", 1, false},
            new object[] {"[0,2,1]", 2, false},
            new object[] {"[4,2,3,0,3,1,2]", 3, true},
            new object[] {"[4,2,3,0,3,1,2]", 5, true},
            new object[] {"[4,2,3,0,3,1,2]", 0, true},
            new object[] {"[3,0,2,1,2]", 2, false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string arrStr, int start, bool expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.CanReach(arr, start);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}