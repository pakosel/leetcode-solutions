using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumAbsoluteDifference

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2]", "[[1,2]]"},
            new object[] {"[2,1]", "[[1,2]]"},
            new object[] {"[4,2,1,3]", "[[1,2],[2,3],[3,4]]"},
            new object[] {"[1,3,6,10,15]", "[[1,3]]"},
            new object[] {"[3,8,-10,23,19,-4,-14,27]", "[[-14,-10],[19,23],[23,27]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string arrStr, string expectedStr)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.MinimumAbsDifference(arr);

            CollectionAssert.AreEqual(res, expected);
        }
    }
}