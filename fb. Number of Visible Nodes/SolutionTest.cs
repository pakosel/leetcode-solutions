using NUnit.Framework;

namespace NumberOfVisibleNodes
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Test_Example1()
        {
            var node = new Node(8) { left = new Node(3) { left = new Node(1), right = new Node(6) {left = new Node(4), right = new Node(7)}}, right = new Node(10) {right = new Node(14) {left = new Node(13)}}};
/*
            8  <------ root
           / \
         3    10
        / \     \
       1   6     14
          / \    /
         4   7  13            
*/            
            var ret = Solution.visibleNodes(node);

            Assert.AreEqual(ret, 4);
        }

        [Test]
        public void Test_Example2()
        {
            var node = new Node(8) { left = new Node(3) { left = new Node(1), right = new Node(6) {left = new Node(4), right = new Node(7)}}, right = new Node(20) {right = new Node(25) {left = new Node(24) {left = new Node(22) {right = new Node(23)}}}}};
/*
            8  <------ root
           / \
         3    20
        / \     \
       1   6     25
          / \    /
         4   7  24
               /
              22
                \
                 23
*/            
            var ret = Solution.visibleNodes(node);

            Assert.AreEqual(ret, 6);
        }
    }

    [TestFixture]
    public class SolutionTest_BST
    {
        [Test]
        [TestCase(new int[] {8,3,1,6,4,7,10,14,13}, 4)]
        [TestCase(new int[] {8,3,1,6,4,7,20,25,24,22,23}, 6)]
        public void Test_Cases(int[] nodes, int expected)
        {
            var bst = new BinarySearchTree();
            for(var i=0; i<nodes.Length; i++)
                bst.insert(nodes[i]);
            var ret = Solution.visibleNodes(bst.root);

            Assert.AreEqual(ret, expected);
        }

        [Test]
        [TestCase(new int[] {8,3,1,6,4,7,10,14,13,}, 4)]
        [TestCase(new int[] {8,3,1,6,4,7,20,25,24,22,23}, 6)]
        public void Test_Cases_Naive(int[] nodes, int expected)
        {
            var bst = new BinarySearchTree();
            for(var i=0; i<nodes.Length; i++)
                bst.insert(nodes[i]);
            var ret = Solution_naive.visibleNodes(bst.root);

            Assert.AreEqual(ret, expected);
        }
    }

    public class BinarySearchTree
    {
        public Node root;

        public void insert(int key)
        {

            // 1) If the tree is empty, create the root
            if (this.root == null)
            {
                this.root = new Node(key);
                return;
            }

            // 2) Otherwise, create a node with the key
            //    and traverse down the tree to find where to
            //    to insert the new node
            Node currentNode = this.root;
            Node newNode = new Node(key);

            while (currentNode != null)
            {
                if (key < currentNode.data)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = newNode;
                        //newNode.parent = currentNode;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                else
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = newNode;
                        //newNode.parent = currentNode;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            }
        }
    }
}