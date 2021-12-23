using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CourseScheduleII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {1, "[]", "[0]"},
            new object[] {2, "[[0,1],[1,0]]", "[]"},
            new object[] {2, "[[1,0]]", "[0,1]"},
            new object[] {4, "[[1,0],[2,0],[3,1],[3,2]]", "[0,2,1,3]"},
            new object[] {7, "[[1,0],[0,3],[0,2],[3,2],[2,5],[4,5],[5,6],[2,4]]", "[6,5,4,2,3,0,1]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(int numCourses, string prereqStr, string expectedStr)
        {
            var prereq = ArrayHelper.MatrixFromString(prereqStr);
            var expected = ArrayHelper.ArrayFromString(expectedStr);

            var sol = new Solution();
            var res = sol.FindOrder(numCourses, prereq);

            CollectionAssert.AreEqual(res, expected);
        }
    }
}