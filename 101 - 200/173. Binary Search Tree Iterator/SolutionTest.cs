using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BinarySearchTreeIterator
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new string[] {"hasNext","next","hasNext"}, "[1]", new object[] { true, 1, false}},
            new object[] {new string[] {"next","next","hasNext","next","hasNext","next","hasNext","next","hasNext"}, "[7,3,15,null,null,9,20]", new object[] { 3, 7, true, 9, true, 15, true, 20, false}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] operations, string nodesArr, object[] expected)
        {
            var root = TreeNodeHelper.BuildTree(nodesArr);

            var sol = new BSTIterator(root);

            for(int i=0; i<operations.Length; i++)
                switch(operations[i])
                {
                    case "next":
                        Assert.AreEqual(sol.Next(), expected[i]);
                        break;
                    case "hasNext":
                        Assert.AreEqual(sol.HasNext(), expected[i]);
                        break;
                }
        }
    }
}