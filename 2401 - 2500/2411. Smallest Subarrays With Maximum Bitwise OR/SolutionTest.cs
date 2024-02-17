using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SmallestSubarraysWithMaximumBitwiseOR
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,0,2,1,3]", "[3,3,2,2,1]"},
            new object[] {"[1,2]", "[2,1]"},
            new object[] {"[0,0,0,0,0,0,0,0]", "[1,1,1,1,1,1,1,1]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);
            
            var sol = new Solution();
            var res = sol.SmallestSubarrays(nums);

            Assert.That(res, Is.EqualTo(expected));
        }
        
        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic_TLE(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);
            
            var sol = new Solution_TLE();
            var res = sol.SmallestSubarrays(nums);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}