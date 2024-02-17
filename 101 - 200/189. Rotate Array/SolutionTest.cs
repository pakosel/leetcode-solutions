using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RotateArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", 0, "[1]"},
            new object[] {"[1]", 2, "[1]"},
            new object[] {"[1]", 1234, "[1]"},
            new object[] {"[1,2,3,4,5,6,7]", 0, "[1,2,3,4,5,6,7]"},
            new object[] {"[1,2,3,4,5,6,7]", 37, "[6,7,1,2,3,4,5]"},
            new object[] {"[1,2,3,4,5,6,7]", 3, "[5,6,7,1,2,3,4]"},
            new object[] {"[-1,-100,3,99]", 2, "[3,99,-1,-100]"},
            new object[] {"[1,2,3,4,5,6]", 2, "[5,6,1,2,3,4]"},
            new object[] {"[1,2,3,4,5,6]", 4, "[3,4,5,6,1,2]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, int k, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution_Basic();
            sol.Rotate(nums, k);

            CollectionAssert.AreEqual(nums, expected);
        }
        
        [Test]
        [TestCaseSource("testCases")]
        public void Test_O_k(string numsStr, int k, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution_O_k();
            sol.Rotate(nums, k);

            CollectionAssert.AreEqual(nums, expected);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_O_1(string numsStr, int k, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution_O_1();
            sol.Rotate(nums, k);

            CollectionAssert.AreEqual(nums, expected);
        }
    }
}