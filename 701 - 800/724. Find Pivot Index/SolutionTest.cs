using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindPivotIndex
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,7,3,6,5,6]", 3},
            new object[] {"[1,2,3]", -1},
            new object[] {"[2,1,-1]", 0},
            new object[] {"[-1,-1,-1,1,1,1]", -1},
            new object[] {"[0]", 0},
            new object[] {"[0,0]", 0},
            new object[] {"[0,0,0]", 0},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.PivotIndex(nums);
            
            Assert.AreEqual(expected, res);
        }
    }
}