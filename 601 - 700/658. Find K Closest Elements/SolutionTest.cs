using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindKClosestElements
{
    [TestFixture]
    public class MaximumBinaryTree
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,3,4,5]", 4, 3, "[1,2,3,4]"},
            new object[] {"[1,2,3,4,5]", 4, -1, "[1,2,3,4]"},
            new object[] {"[0,0,1,2,3,3,4,7,7,8]", 3, 5, "[3,3,4]"},
            new object[] {"[1,3]", 1, 2, "[1]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string arrStr, int k, int x, string expectedStr)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.FindClosestElements(arr, k, x);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}