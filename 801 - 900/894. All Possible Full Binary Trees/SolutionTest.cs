using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace AllPossibleFullBinaryTrees
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, new string[] {"[0]"}},
            new object[] {2, new string[] {}},
            new object[] {3, new string[] {"[0,0,0]"}},
            new object[] {4, new string[] {}},
            new object[] {5, new string[] {"[0,0,0,null,null,0,0]","[0,0,0,0,0]"}},
            new object[] {6, new string[] {}},
            new object[] {7, new string[] {"[0,0,0,null,null,0,0,null,null,0,0]","[0,0,0,null,null,0,0,0,0]","[0,0,0,0,0,0,0]","[0,0,0,0,0,null,null,null,null,0,0]","[0,0,0,0,0,null,null,0,0]"}},
            new object[] {8, new string[] {}},
            new object[] {9, new string[] {"[0,0,0,null,null,0,0,null,null,0,0,null,null,0,0]","[0,0,0,null,null,0,0,null,null,0,0,0,0]","[0,0,0,null,null,0,0,0,0,0,0]","[0,0,0,null,null,0,0,0,0,null,null,null,null,0,0]","[0,0,0,null,null,0,0,0,0,null,null,0,0]","[0,0,0,0,0,0,0,null,null,null,null,null,null,0,0]","[0,0,0,0,0,0,0,null,null,null,null,0,0]","[0,0,0,0,0,0,0,null,null,0,0]","[0,0,0,0,0,0,0,0,0]","[0,0,0,0,0,null,null,null,null,0,0,null,null,0,0]","[0,0,0,0,0,null,null,null,null,0,0,0,0]","[0,0,0,0,0,null,null,0,0,0,0]","[0,0,0,0,0,null,null,0,0,null,null,null,null,0,0]","[0,0,0,0,0,null,null,0,0,null,null,0,0]]"}},
            new object[] {20, new string[] {}},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int n, string[] expectedArr)
        {
            var expected = expectedArr.Select(s => TreeNodeHelper.BuildTree(s)).ToList();

            var sol = new Solution();
            var res = sol.AllPossibleFBT(n);
            
            Assert.That(res, Is.EquivalentTo(expected));
        }
    }
}