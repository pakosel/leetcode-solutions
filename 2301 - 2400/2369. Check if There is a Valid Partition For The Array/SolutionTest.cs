using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CheckIfThereIsValidPartitionForTheArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,1]", true},
            new object[] {"[1,2,3]", true},
            new object[] {"[1,2,3,4]", false},
            new object[] {"[1,1,2]", false},
            new object[] {"[4,4,4,5,6]", true},
            new object[] {"[4,4,4,4,5,6]", true},
            new object[] {"[1,1,1,2]", false},
            new object[] {"[1,1,1,2,3]", true},
            new object[] {"[1,1,1,1,2,3]", true},
            new object[] {"[4,4,4,4,4,5,6]", true},
            new object[] {"[5,6,7,8,9,10,11]", false},
            new object[] {"[993335,993336,993337,993338,993339,993340,993341]", false},
            new object[] {"[5,6,7,1,9,10,11]", false},
            new object[] {"[5,6,7,88,9,10,11]", false},
            new object[] {"[3,3,3,2,2]", true},
            new object[] {"[3,3,3,1,2,2]", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, bool expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            
            var sol = new Solution();
            var res = sol.ValidPartition(nums);

            Assert.AreEqual(expected, res);
        }
    }
}