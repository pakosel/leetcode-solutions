using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SymmetricTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", true },
            new object[] {"[1,2,2]", true },
            new object[] {"[1,2,3]", false },
            new object[] {"[1,null,3]", false },
            new object[] {"[1,2]", false },
            new object[] {"[1,2,2,3,4,4,3]", true },
            new object[] {"[1,2,2,null,3,null,3]", false },
            new object[] {"[1,2,2,2,null,2]", false },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic2023(string rootStr, bool expected)
        {
            var root = TreeNodeHelper.BuildTree(rootStr);

            var sol = new Solution_2023();
            var res = sol.IsSymmetric(root);

            ClassicAssert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Queue(string rootStr, bool expected)
        {
            var root = TreeNodeHelper.BuildTree(rootStr);

            var sol = new Solution_Queue();
            var res = sol.IsSymmetric(root);

            ClassicAssert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string rootStr, bool expected)
        {
            var root = TreeNodeHelper.BuildTree(rootStr);
            
            var sol = new Solution_Stack();
            var res = sol.IsSymmetric(root);

            ClassicAssert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Recursive(string rootStr, bool expected)
        {
            var root = TreeNodeHelper.BuildTree(rootStr);
            
            var sol = new Solution_Recursive();
            var res = sol.IsSymmetric(root);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}