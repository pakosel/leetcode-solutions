using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace MergeTwoSortedLists
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("[1,2,4]", "[1,3,4]", "[1,1,2,3,4,4]")]
        public void Test_Example(string list1, string list2, string expected)
        {
            var l1 = new ListNode(1) { next = new ListNode(2) { next = new ListNode(4)}};
            var l2 = new ListNode(1) { next = new ListNode(3) { next = new ListNode(4)}};

            var sol = new Solution();
            var ret = sol.MergeTwoLists(l1, l2);

            var lst = new List<int>();
            while(ret != null) {
                lst.Add(ret.val);
                ret = ret.next;
            }
            var retListStr = '[' + string.Join(',', lst) + ']';

            Assert.That(retListStr == expected);
        }

        [Test]
        [TestCase("[]", "[]", "[]")]
        public void Test_Empty(string list1, string list2, string expected)
        {
            var sol = new Solution();
            var ret = sol.MergeTwoLists(null, null);

            var lst = new List<int>();
            while(ret != null) {
                lst.Add(ret.val);
                ret = ret.next;
            }
            var retListStr = '[' + string.Join(',', lst) + ']';

            Assert.That(retListStr == expected);
        }
    }
}