using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace GroupPeopleGivenGroupSizeTheyBelongTo
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[3,3,3,3,3,1,3]", "[[0,1,2],[3,4,6],[5]]"},
            new object[] {"[2,1,3,3,3,2]", "[[0,5],[1],[2,3,4]]"},
            new object[] {"[1]", "[[0]]"},
            new object[] {"[1,1]", "[[0],[1]]"},
            new object[] {"[1,1,1]", "[[0],[1],[2]]"},
            new object[] {"[2,2]", "[[0,1]]"},
            new object[] {"[3,3,3]", "[[0,1,2]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string groupSizesStr, string expectedStr)
        {
            var groupSizes = ArrayHelper.ArrayFromString<int>(groupSizesStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.GroupThePeople(groupSizes);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}