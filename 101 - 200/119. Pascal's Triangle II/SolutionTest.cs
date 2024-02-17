using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PascalTriangleII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {0, "[1]"},
            new object[] {1, "[1,1]"},
            new object[] {2, "[1,2,1]"},
            new object[] {3, "[1,3,3,1]"},
            new object[] {4, "[1,4,6,4,1]"},
            new object[] {5, "[1,5,10,10,5,1]"},
            new object[] {33, "[1,33,528,5456,40920,237336,1107568,4272048,13884156,38567100,92561040,193536720,354817320,573166440,818809200,1037158320,1166803110,1166803110,1037158320,818809200,573166440,354817320,193536720,92561040,38567100,13884156,4272048,1107568,237336,40920,5456,528,33,1]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int rowIndex, string expectedStr)
        {
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.GetRow(rowIndex);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}