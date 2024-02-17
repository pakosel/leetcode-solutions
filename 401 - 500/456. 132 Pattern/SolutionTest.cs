using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace The132Pattern
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,3,4]", false},
            new object[] {"[3,1,4,2]", true},
            new object[] {"[-1,3,2,0]", true},
            new object[] {"[8,7,6,8,1,5,8]", false},
            new object[] {"[8,7,6,8,1,5,8,4]", true},
            new object[] {"[8,7,6,8,1,5,8,7]", true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, bool expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.Find132pattern(nums);
            
            Assert.That(expected == res);
        }
    }
}