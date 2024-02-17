using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SearchInRotatedSortedArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[0]", 0, 0},
            new object[] {"[0]", 1, -1},
            new object[] {"[0,1]", 3, -1},
            new object[] {"[1,0]", 3, -1},
            new object[] {"[3,1]", 3, 0},
            new object[] {"[2,5,6,0,1,2]", 0, 3},
            new object[] {"[2,5,6,0,0,1,2]", 3, -1},
            new object[] {"[6,7,0,2,3,5]", 5, 5},
            new object[] {"[6,7,0,2,3,5]", 2, 3},
            new object[] {"[6,7,0,2,3,5]", 1, -1},
            new object[] {"[4,5,6,7,0,1,2]", 0, 4},
            new object[] {"[4,5,6,7,0,1,2]", 3, -1},
            
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string arrStr, int target, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.Search(nums, target);

            Assert.That(expected == res);
        }
    }
}