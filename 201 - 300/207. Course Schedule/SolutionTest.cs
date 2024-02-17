using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CourseSchedule
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {2, "[[1,0]]", true},
            new object[] {2, "[[1,0],[0,1]]", false},
            new object[] {4, "[[0,1],[1,2],[3,2]]", true},
            new object[] {4, "[[0,1],[1,2],[3,2],[0,3]]", true},
            new object[] {4, "[[0,1],[1,2],[3,2],[3,0]]", true},
            new object[] {4, "[[0,1],[1,2],[3,2],[2,0]]", false},
            new object[] {4, "[[1,0],[2,0],[3,1],[3,2]]", true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Solution2022(int numCourses, string prerequisitesStr, bool expected)
        {
            var prerequisites = ArrayHelper.MatrixFromString<int>(prerequisitesStr);

            var sol = new Solution();
            var res = sol.CanFinish(numCourses, prerequisites);

            Assert.That(expected == res);
        }
    }
}