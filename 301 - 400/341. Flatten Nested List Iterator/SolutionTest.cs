using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FlattenNestedListIterator
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[1,1],2,[1,1]]", "[1,1,2,1,1]"},
            new object[] {"[1,[4,[6]]]", "[1,4,6]"},
            new object[] {"[-1,[-4,[6,-5,2]]]", "[-1,-4,6,-5,2]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string listStr, string expectedStr)
        {
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);
            var list = NestedIntegerImpl.BuildListFromString(listStr);

            var sol = new NestedIterator(list);
            var res = new List<int>();
            while (sol.HasNext())
                res.Add(sol.Next());

            CollectionAssert.AreEqual(expected, res);
        }
    }
}