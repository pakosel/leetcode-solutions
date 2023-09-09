using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PascalTriangle
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {1, "[[1]]"},
            new object[] {2, "[[1],[1,1]]"},
            new object[] {3, "[[1],[1,1],[1,2,1]]"},
            new object[] {4, "[[1],[1,1],[1,2,1],[1,3,3,1]]"},
            new object[] {5, "[[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic23(int rowNum, string expectedStr)
        {
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution_2023();
            var res = sol.Generate(rowNum);

            CollectionAssert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int rowNum, string expectedStr)
        {
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.GeneratePascal(rowNum);

            CollectionAssert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenList(int rowNum, string expectedStr)
        {
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.GeneratePascal_GenList(rowNum);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}