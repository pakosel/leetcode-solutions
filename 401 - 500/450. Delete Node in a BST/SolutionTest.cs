using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DeleteNodeInBst
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", 0, "[]"},
            new object[] {"[5,3,6,2,4,null,7]", 3, "[5,4,6,2,null,null,7]"},
            new object[] {"[5,3,6,2,4,null,7]", 0, "[5,3,6,2,4,null,7]"},
            new object[] {"[5,3,6,2,4,null,7]", 7, "[5,3,6,2,4]"},
            new object[] {"[3,2,5,null,null,4,10,null,null,8,15,7]", 5, "[3,2,7,null,null,4,10,null,null,8,15]"},
            new object[] {"[50,30,70,null,40,60,80]", 50, "[60,30,70,null,40,null,80]"},
            new object[] {"[4,null,7,6,8,5,null,null,9]", 7, "[4,null,8,6,9,5]"},
            new object[] {"[3,2,4,1]", 2, "[3,1,4]"},
            new object[] {"[3,1,4,null,2]", 1, "[3,2,4]"},
            new object[] {"[2,0,33,null,1,25,40,null,null,11,31,34,45,10,18,29,32,null,36,43,46,4,null,12,24,26,30,null,null,35,39,42,44,null,48,3,9,null,14,22,null,null,27,null,null,null,null,38,null,41,null,null,null,47,49,null,null,5,null,13,15,21,23,null,28,37,null,null,null,null,null,null,null,null,8,null,null,null,17,19,null,null,null,null,null,null,null,7,null,16,null,null,20,6]", 33, "[2,0,34,null,1,25,40,null,null,11,31,36,45,10,18,29,32,35,39,43,46,4,null,12,24,26,30,null,null,null,null,38,null,42,44,null,48,3,9,null,14,22,null,null,27,null,null,37,null,41,null,null,null,47,49,null,null,5,null,13,15,21,23,null,28,null,null,null,null,null,null,null,null,null,8,null,null,null,17,19,null,null,null,null,null,7,null,16,null,null,20,6]"},
            new object[] {"[5,3,6,2,4,null,null,1]", 3, "[5,4,6,2,null,null,null,1]"},
            new object[] {"[27,17,33,15,26,32,45,7,16,23,null,31,null,40,49,5,14,null,null,21,25,29,null,34,41,48,null,2,6,10,null,20,22,24,null,28,30,null,39,null,42,46,null,1,4,null,null,9,11,18,null,null,null,null,null,null,null,null,null,37,null,null,44,null,47,0,null,3,null,8,null,null,13,null,19,35,38,43,null,null,null,null,null,null,null,null,null,12,null,null,null,null,36]", 49, "[27,17,33,15,26,32,45,7,16,23,null,31,null,40,48,5,14,null,null,21,25,29,null,34,41,46,null,2,6,10,null,20,22,24,null,28,30,null,39,null,42,null,47,1,4,null,null,9,11,18,null,null,null,null,null,null,null,null,null,37,null,null,44,null,null,0,null,3,null,8,null,null,13,null,19,35,38,43,null,null,null,null,null,null,null,12,null,null,null,null,36]"},
            new object[] {"[2,1]", 1, "[2]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string inputStr, int key, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(inputStr);

            var sol = new Solution();
            var res = sol.DeleteNode(root, key);

            var expected = TreeNodeHelper.BuildTree(expectedStr);

            Assert.That(TreeNodeHelper.CompareTreeNode(res, expected));
        }
    }
}