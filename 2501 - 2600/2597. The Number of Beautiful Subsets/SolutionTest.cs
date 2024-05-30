using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TheNumberOfBeautifulSubsets
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2,4,6]", 2, 4},
            new object[] {"[1]", 1, 1},
            new object[] {"[310,210,726,347,2,665,800,749,751,600,580,942,966,198,886,15,607,439,725,279]", 711, 786431},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string numsStr, int k, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            
            var sol = new Solution();
            var res = sol.BeautifulSubsets(nums, k);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}