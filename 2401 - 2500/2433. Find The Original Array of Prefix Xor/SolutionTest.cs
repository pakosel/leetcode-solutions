using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindTheOriginalArrayOfPrefixXor
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[5,2,0,3,1]", "[5,7,2,3,2]"},
            new object[] {"[13]", "[13]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);
            
            var sol = new Solution();
            var res = sol.FindArray(nums);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}