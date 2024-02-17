using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace InsertionSortList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new int[] { }, new int[] { } },
            new object[] { new int[] { 0 }, new int[] { 0 } },
            new object[] { new int[] { 0,1 }, new int[] { 0,1 } },
            new object[] { new int[] { 1,0 }, new int[] { 0,1 } },
            new object[] { new int[] { 0,0,0 }, new int[] { 0,0,0 } },
            new object[] { new int[] { 1,0,1 }, new int[] { 0,1,1 } },
            new object[] { new int[] { 4,2,1,3 }, new int[] { 1,2,3,4 } },
            new object[] { new int[] { -1,5,3,4,0 }, new int[] { -1,0,3,4,5 } },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int[] list, int[] expected)
        {
            var head = new ListNode().FromGenericList(list.ToList());

            var sol = new Solution();
            var res = sol.InsertionSortList(head);

            Assert.That(res.ToGenericList(), Is.EqualTo(expected));
        }
    }

    public static class ListNodeExt
    {
        public static List<int> ToGenericList(this ListNode head)
        {
            var res = new List<int>();

            while(head != null)
            {
                res.Add(head.val);
                head = head.next;
            }

            return res;
        }

        public static ListNode FromGenericList(this ListNode head, List<int> list)
        {
            if(list.Count == 0)
                return null;

            head = new ListNode(list[0]);
            var curr = head;
            for(int i=1; i<list.Count; i++)
            {
                curr.next = new ListNode(list[i]);
                curr = curr.next;
            }

            return head;
        }
    }
}