using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumNumberOfOperationsToMakeArrayEmpty
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2,3,3,2,2,4,2,3,4]", 4},
            new object[] {"[2,1,2,2,3,3]", -1},
            new object[] {"[1,1,2,2,2,3,3,3,3]", 4},
            new object[] {"[5,5,5,5,5]", 2},
            new object[] {"[5,5,5,5,5,5]", 2},
            new object[] {"[5,5,5,5,5,5,5]", 3},
            new object[] {"[5,5,5,5,5,5,5,5]", 3},
            new object[] {"[5,5,5,5,5,5,5,5,5]", 3},
            new object[] {"[5,5,5,5,5,5,5,5,5,5]", 4},
            new object[] {"[5,5,5,5,5,5,5,5,5,5,5,5,5]", 5},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.MinOperations(nums);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}