using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace PascalTriangle
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(1, "[[1]]")]
        [TestCase(2, "[[1],[1,1]]")]
        [TestCase(3, "[[1],[1,1],[1,2,1]]")]
        [TestCase(4, "[[1],[1,1],[1,2,1],[1,3,3,1]]")]
        [TestCase(5, "[[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]")]
        public void Test_Example(int rowNum, string expected)
        {
            var sol = new Solution();
            var ret = sol.GeneratePascal(rowNum);

            StringBuilder sb = new StringBuilder();
            sb.Append('[');
            sb.Append(string.Join(',', ret.Select(it => "[" + string.Join(',', it) + "]")));
            sb.Append(']');

            Assert.AreEqual(sb.ToString(), expected);
        }
    }
}