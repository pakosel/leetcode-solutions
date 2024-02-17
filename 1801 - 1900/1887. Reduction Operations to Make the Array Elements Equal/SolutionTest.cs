using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ReductionOperationsToMakeTheArrayElementsEqual
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[5,1,3]", 3},
            new object[] {"[1,1,1]", 0},
            new object[] {"[1,1,2,2,3]", 4},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.ReductionOperations(nums);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}