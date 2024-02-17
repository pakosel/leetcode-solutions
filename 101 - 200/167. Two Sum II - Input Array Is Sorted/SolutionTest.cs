using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TwoSumIIinputArrayIsSorted

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[2,7,11,15]", 9, "[1,2]"},
            new object[] {"[2,3,4]", 6, "[1,3]"},
            new object[] {"[-1,0]", -1, "[1,2]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numbersStr, int target, string expectedStr)
        {
            var numbers = ArrayHelper.ArrayFromString<int>(numbersStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);
            
            ClassicAssert.GreaterOrEqual(numbers.Length, 2);
            ClassicAssert.AreEqual(2, expected.Length);

            var sol = new Solution();
            var res = sol.TwoSum(numbers, target);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}