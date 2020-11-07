using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace AddTwoNumbersII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[7,2,4,3]", "[5,6,4]", "7,8,0,7" },
            new object[] { "[3,9,9,9,9,9,9,9,9,9]", "[7]", "[4,0,0,0,0,0,0,0,0,6]" },
            //new object[] { "[2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,9]", "[5,6,4,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,9,9,9,9]", "[8,0,7,4,8,6,4,8,6,4,8,6,4,8,6,4,8,6,4,8,6,4,8,6,4,8,6,4,8,6,4,8,6,4,8,6,4,8,6,4,8,6,4,8,6,4,8,6,4,8,6,4,8,6,4,8,7,2,4,3,8]" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string strL1, string strL2, string expected)
        {
            var sol = new Solution();
            var res = sol.AddTwoNumbers(ArrToList(strL1), ArrToList(strL2));

            ListNodeEquals(res, ArrToList(expected));
        }

        private ListNode ArrToList(string arrStr)
        {
            var arr = arrStr.TrimStart('[').TrimEnd(']').Split(",")
                .Select(s => int.Parse(s)).ToArray();

            Assert.IsTrue(arr.Length > 0);

            ListNode head = null;
            for(int i=arr.Length - 1; i >= 0; i--)
                head = new ListNode(arr[i], head);

            return head;
        }

        private bool ListNodeEquals(ListNode l1, ListNode l2)
        {
            while(l1 != null)
            {
                Assert.AreEqual(l1.val, l2.val);
                if(l1.val != l2.val)
                    return false;
                l1 = l1.next;
                l2 = l2.next;
            }

            Assert.IsNull(l2);

            return true;
        }
    }
}