using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DeleteColumnsToMakeSorted
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[cba,daf,ghi]", 1},
            new object[] {"[a,b]", 0},
            new object[] {"[zyx,wvu,tsr]", 3},
            
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Memoization(string arrStr, int expected)
        {
            var arr = ArrayHelper.ArrayFromString<string>(arrStr);

            var sol = new Solution();
            var res = sol.MinDeletionSize(arr);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}