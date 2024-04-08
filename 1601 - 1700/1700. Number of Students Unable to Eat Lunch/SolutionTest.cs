using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOfStudentsUnableToEatLunch
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,1,0,0]", "[0,1,0,1]", 0},
            new object[] {"[1,1,1,0,0,1]", "[1,0,0,0,1,1]", 3},
            new object[] {"[1]", "[0]", 1},
            new object[] {"[1]", "[1]", 0},
            new object[] {"[1,0]", "[1,0]", 0},
            new object[] {"[1,0]", "[0,1]", 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string studentStr, string sandwichStr, int expected)
        {
            var students = ArrayHelper.ArrayFromString<int>(studentStr);
            var sandwitches = ArrayHelper.ArrayFromString<int>(sandwichStr);

            var sol = new Solution();
            var res = sol.CountStudents(students, sandwitches);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}