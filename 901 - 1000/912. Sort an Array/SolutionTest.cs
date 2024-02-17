using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SortAnArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0]", "[0]"},
            new object[] {"[3,1,2,4]", "[1,2,3,4]"},
            new object[] {"[5,2,3,1]", "[1,2,3,5]"},
            new object[] {"[5,1,1,2,0,0]", "[0,0,1,1,2,5]"},
            new object[] {"[4,12,7,1,6,2,3,8,10,5]", "[1,2,3,4,5,6,7,8,10,12]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);
            
            var sol = new Solution();
            var res = sol.SortArray(nums);
            
            Assert.That(res, Is.EqualTo(expected));
        }
    }
}