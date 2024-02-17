using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace UniqueBinarySearchTreesII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {1, new string[] {"[1]"}},
            new object[] {2, new string[] {"[1,null,2]","[2,1]"}},
            new object[] {3, new string[] {"[1,null,2,null,3]","[1,null,3,2]","[2,1,3]","[3,1,null,null,2]","[3,2,null,1]"}},
            new object[] {4, new string[] {"[1,null,2,null,3,null,4]","[1,null,2,null,4,3]","[1,null,3,2,4]","[1,null,4,2,null,null,3]","[1,null,4,3,null,2]","[2,1,3,null,null,null,4]","[2,1,4,null,null,3]","[3,1,4,null,2]","[3,2,4,1]","[4,1,null,null,2,null,3]","[4,1,null,null,3,2]","[4,2,null,1,3]","[4,3,null,1,null,null,2]","[4,3,null,2,null,1]"}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, string[] expectedArr)
        {
            var expected = expectedArr.Select(s => TreeNodeHelper.BuildTree(s)).ToList();

            var sol = new Solution();
            var res = sol.GenerateTrees(n);

            CollectionAssert.AreEquivalent(expected, res);
        }
    }
}