using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace AverageOfLevelsInBinaryTree
{
    [TestFixture]
    public class MaximumBinaryTree
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", new double[] {1.00000}},
            new object[] {"[-4]", new double[] {-4.00000}},
            new object[] {"[3,9,20,null,null,15,7]", new double[] {3.00000,14.50000,11.00000}},
            new object[] {"[3,9,20,15,7]", new double[] {3.00000,14.50000,11.00000}},
            new object[] {"[3,9,20,null,1,3,7]", new double[] {3.00000,14.50000,3.66667}},
            new object[] {"[3,9,20,null,1,-3,7]", new double[] {3.00000,14.50000,1.66667}},
            new object[] {"[2147483647,2147483647,2147483647]", new double[] {2147483647.00000,2147483647.00000}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, double[] expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.AverageOfLevels(root);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}