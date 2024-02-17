using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MostBeautifulItemForEachQuery
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,2],[3,2],[2,4],[5,6],[3,5]]", "[1,2,3,4,5,6]", "[2,4,5,5,6,6]"},
            new object[] {"[[1,2],[1,2],[1,3],[1,4]]", "[1]", "[4]"},
            new object[] {"[[10,1000]]", "[5]", "[0]"},
            new object[] {"[[124,431],[460,640],[263,940],[981,122],[845,113],[323,853],[836,419],[816,332],[622,765],[408,739],[143,389],[379,834],[308,592],[246,318],[372,732],[749,149],[549,559],[207,670],[764,102]]", "[670,1452,613,304,1031,1454,390,822,842,184,324,429,255]", "[940,940,940,940,940,940,940,940,940,431,940,940,670]"},
        };


        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string itemsStr, string queriesStr, string expectedStr)
        {
            var items = ArrayHelper.MatrixFromString<int>(itemsStr);
            var queries = ArrayHelper.ArrayFromString<int>(queriesStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            Assert.That(queries.Length == expected.Length);

            var sol = new Solution();
            var res = sol.MaximumBeauty(items, queries);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}