using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ArithmeticSubarrays
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[4,6,5,9,3,7]", "[0,0,2]", "[2,3,5]", "[true,false,true]"},
            new object[] {"[-12,-9,-3,-12,-6,15,20,-25,-20,-15,-10]", "[0,1,6,4,8,7]", "[4,4,9,7,9,10]", "[false,true,false,false,true,true]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string numsStr, string lStr, string rStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var l = ArrayHelper.ArrayFromString<int>(lStr);
            var r = ArrayHelper.ArrayFromString<int>(rStr);
            var expected = ArrayHelper.ArrayFromString<bool>(expectedStr);

            var sol = new Solution();
            var res = sol.CheckArithmeticSubarrays(nums, l, r);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}