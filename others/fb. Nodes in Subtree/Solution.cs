using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NodesInSubtree
{
    public class Solution
    {
        public static int[] countOfNodes(Node root, List<Query> queries, String s)
        {
            //edge cases
            if(root == null || string.IsNullOrEmpty(s))
                return new int[0];

            //var ret = new int[queries.Count];
            var ret = new List<int>();
            var dict = TraverseTree(root, s);

            foreach(var q in queries)
                //count the number of elements in a list that equals to 'c'
                ret.Add(dict[q.v].Count(e => e == q.c));

            return ret.ToArray();
        }

        private static Dictionary<int, List<char>> TraverseTree(Node root, string s)
        {
            var dict = new Dictionary<int, List<char>>();
            for(int i=1; i<=s.Length; i++)
                dict.Add(i, new List<char>());
            
            var stack = new Stack< KeyValuePair<Node, List<int>> >();  //nodes to process with a list of all parents
            stack.Push(new KeyValuePair<Node, List<int>>(root, new List<int>()));  //root node has no parent

            while(stack.Count() > 0)
            {
                var nodeKvp = stack.Pop();
                var nodeVal = nodeKvp.Key.val;
                dict[nodeVal].Add(s[nodeVal-1]);  //node keys are 1-based indexed

                foreach(var parent in nodeKvp.Value)
                    dict[parent].Add(s[nodeVal-1]);
                foreach(var children in nodeKvp.Key.children)
                    //add children node with a list of parent nodes plus a parent itself
                    stack.Push( new KeyValuePair<Node, List<int>>(children, new List<int>() { nodeVal }.Concat(nodeKvp.Value).ToList()));
            }

            return dict;
        }

    }

    public class Node
    {
        public int val;
        public List<Node> children;

        public Node()
        {
            val = 0;
            children = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            children = new List<Node>();
        }

        public Node(int _val, List<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }

    public class Query
    {
        public int v;
        public char c;
        public Query(int v, char c)
        {
            this.v = v;
            this.c = c;
        }
    }
}