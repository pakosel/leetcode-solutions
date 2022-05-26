using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SortArrayByParity
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0]", "[0]"},
            new object[] {"[3,1,2,4]", "[2,4,3,1]"},
            new object[] {"[3,1,4,4,2,0]", "[4,4,2,0,3,1]"},
            new object[] {"[3,1,4,4,2,0]", "[4,4,2,0,3,1]"},
            new object[] {"[2,4,6,8,10]", "[2,4,6,8,10]"},
            new object[] {"[2,4,4,4]", "[2,4,4,4]"},
            new object[] {"[2,4,4,1,1,3,5]", "[2,4,4,1,1,3,5]"},
            new object[] {"[2,1,2,1,2,1]", "[2,2,2,1,1,1]"},
            new object[] {"[2,1,2,1,2]", "[2,2,2,1,1]"},
            new object[] {"[1,2,1,2,1]", "[2,2,1,1,1]"},
            new object[] {"[1,2,1,2]", "[2,2,1,1]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);
            
            var sol = new Solution();
            var res = sol.SortArrayByParity(nums);
            
            CollectionAssert.AreEqual(res, expected);
        }
        
        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Linq(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);
            
            var sol = new Solution_Linq();
            var res = sol.SortArrayByParity(nums);
            
            CollectionAssert.AreEqual(res, expected);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_InPlace(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);
            
            var sol = new Solution_InPlace();
            var res = sol.SortArrayByParity(nums);
            
            CollectionAssert.AreEqual(res, expected);
        }
        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_2pass(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);
            
            var sol = new Solution_2pass();
            var res = sol.SortArrayByParity(nums);
            
            CollectionAssert.AreEqual(res, expected);
        }
    }
}