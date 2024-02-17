using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SearchInRotatedSortedArrayII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[0]", 0, true},
            new object[] {"[0]", 1, false},
            new object[] {"[0,1]", 3, false},
            new object[] {"[1,0]", 3, false},
            new object[] {"[3,1]", 3, true},
            new object[] {"[2,5,6,0,0,1,2]", 0, true},
            new object[] {"[2,5,6,0,0,1,2]", 3, false},
            new object[] {"[6,7,0,2,3,5]", 5, true},
            new object[] {"[6,7,0,2,3,5]", 2, true},
            new object[] {"[6,7,0,2,3,5]", 1, false},
            
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string arrStr, int target, bool expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.Search(nums, target);

            Assert.That(expected == res);
        }
    }
}