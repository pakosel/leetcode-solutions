using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ConvertArrayInto2DArrayWithConditions
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,3,4,1,2,3,1]", "[[1,3,4,2],[1,3],[1]]"},
            new object[] {"[2,1,1]", "[[2,1],[1]]"},
            new object[] {"[1,1,1,1,3,4,1,2,3,1,1,3,4,1,2,3,1,1,3,4,1,2,3,1,1,1,1,1,3,4,1,2,3,1,1,3,4,1,2,3,1,1,3,4,1,2,3,1,1,1,1,1,3,4,1,2,3,1,1,3,4,1,2,3,1,1,3,4,1,2,3,1,1,1,1,1,3,4,1,2,3,1,1,3,4,1,2,3,1,1,3,4,1,2,3,1,1,1,1,1,3,4,1,2,3,1,1,3,4,1,2,3,1,1,3,4,1,2,3,1,1,1,1,1,3,4,1,2,3,1,1,3,4,1,2,3,1,1,3,4,1,2,3,11,1,1,1,3,4,1,2,3,1,1,3,4,1,2,3,1,1,3,4,1,2,3,1,1,1,1,1,3,4,1,2,3,1,1,3,4,1,2,3,1,1,3,4,1,2,3,1,1,1,1,1,3,4,1]", "[[1,3,4,2,11],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4,2],[1,3,4],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1,3],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.FindMatrix(nums);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}