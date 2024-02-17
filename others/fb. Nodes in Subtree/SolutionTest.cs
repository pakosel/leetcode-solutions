using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;

namespace NodesInSubtree
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Test_Example1()
        {
            var s_1 = "aba";
            var root_1 = new Node(1);
            root_1.children.Add(new Node(2));
            root_1.children.Add(new Node(3));
            var queries_1 = new List<Query>();
            queries_1.Add(new Query(1, 'a'));
            int[] output_1 = Solution.countOfNodes(root_1, queries_1, s_1);
            int[] expected_1 = { 2 };

            // foreach(var e in output_1)
            //     Console.Out.WriteLine(e);

            CollectionAssert.AreEqual(expected_1, output_1);
        }

        [Test]
        public void Test_Example2()
        {
            var s_2 = "abaacab";
            var root_2 = new Node(1);
            root_2.children.Add(new Node(2));
            root_2.children.Add(new Node(3));
            root_2.children.Add(new Node(7));
            root_2.children[0].children.Add(new Node(4));
            root_2.children[0].children.Add(new Node(5));
            root_2.children[1].children.Add(new Node(6));
            var queries_2 = new List<Query>();
            queries_2.Add(new Query(1, 'a'));
            queries_2.Add(new Query(2, 'b'));
            queries_2.Add(new Query(3, 'a'));
            int[] output_2 = Solution.countOfNodes(root_2, queries_2, s_2);
            int[] expected_2 = { 4, 1, 2 };

            CollectionAssert.AreEqual(expected_2, output_2);
        }
    }
}