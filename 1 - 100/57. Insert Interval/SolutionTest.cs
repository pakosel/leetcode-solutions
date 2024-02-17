using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace InsertInterval
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[1,3],[6,9]]", "[2,5]", "[[1,5],[6,9]]"},
            new object[] {"[[1,2],[3,5],[6,7],[8,10],[12,16]]", "[4,8]", "[[1,2],[3,10],[12,16]]"},
            new object[] {"[[1,5]]", "[1,7]", "[[1,7]]"},
            new object[] {"[[1,5]]", "[6,8]", "[[1,5],[6,8]]"},
            new object[] {"[[1,5]]", "[5,8]", "[[1,8]]"},
            new object[] {"[[1,5]]", "[2,3]", "[[1,5]]"},
            new object[] {"[[1,5]]", "[0,3]", "[[0,5]]"},
            new object[] {"[[1,5]]", "[0,0]", "[[0,0],[1,5]]"},
            new object[] {"[[1,3],[6,9],[15,16]]", "[2,15]", "[[1,16]]"},
            new object[] {"[[1,3],[6,9],[15,16]]", "[0,1]", "[[0,3],[6,9],[15,16]]"},
            new object[] {"[[2,3],[6,9],[15,16]]", "[0,1]", "[[0,1],[2,3],[6,9],[15,16]]"},
            new object[] {"[[2,3],[6,9],[15,16]]", "[0,15]", "[[0,16]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic2022(string intervalsStr, string newIntervalStr, string expectedStr)
        {
            var intervals = ArrayHelper.MatrixFromString<int>(intervalsStr);
            var newInterval = ArrayHelper.ArrayFromString<int>(newIntervalStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution_2022();
            var res = sol.Insert(intervals, newInterval);

            CollectionAssert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string intervalsStr, string newIntervalStr, string expectedStr)
        {
            var intervals = ArrayHelper.MatrixFromString<int>(intervalsStr);
            var newInterval = ArrayHelper.ArrayFromString<int>(newIntervalStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.Insert(intervals, newInterval);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}