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

        public void Test_Example2()
        {
            var node = new Node(8) { left = new Node(3) { left = new Node(1), right = new Node(6) {left = new Node(4), right = new Node(7)}}, right = new Node(20) {right = new Node(24) {left = new Node(13) {left = new Node(10) {right = new Node(11)}}}}};
/*
            8  <------ root
           / \
         3    20
        / \     \
       1   6     24
          / \    /
         4   7  13
               /
              10
                \
                 11
*/            
            var ret = Solution.visibleNodes(node);

            Assert.AreEqual(ret, 6);
        }
    }
}