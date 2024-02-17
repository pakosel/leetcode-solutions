using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace ConvertBinaryNumberInLinkedList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0]", 0},
            new object[] {"[0,0]", 0},
            new object[] {"[1]", 1},
            new object[] {"[1,0,1]", 5},
            new object[] {"[1,0,0,1,0,0,1,1,1,0,0,0,0,0,0]", 18880},
            new object[] {"[1,0,0,1,1,0,1,1,1,1,0,1,0,1,1,0,1,1,1,0,1,0,1,0,1,1,1]", 81704791},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string arrStr, int expected)
        {
            var arr = arrStr.TrimStart('[').TrimEnd(']').Split(",")
                .Select(s => int.Parse(s)).ToArray();

            Assert.That(arr.Length > 0);

            ListNode curr = new ListNode(arr[0]);
            var head = curr;
            for(int i=1; i<arr.Length; i++)
            {
                curr.next = new ListNode(arr[i]);
                curr = curr.next;
            }

            var sol = new Solution();
            var res = sol.GetDecimalValue(head);

            Assert.That(expected == res);
        }
    }
}