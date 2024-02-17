using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace ReverseLinkedListII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new ListNode(1), 1, 1, new ListNode(1) },
            //[1,2] 1 2 [2,1]
            new object[] { new ListNode(1) {next = new ListNode(2) }, 1, 2,
                           new ListNode(2) {next = new ListNode(1) } },
            //[1,2,3,4] 2 3 [1,3,2,4]
            new object[] { new ListNode(1) {next = new ListNode(2) {next = new ListNode(3) {next = new ListNode(4) }}}, 2, 3,
                           new ListNode(1) {next = new ListNode(3) {next = new ListNode(2) {next = new ListNode(4) }}} },
            //[1,2,3,4,5] 4 5 [1,2,3,5,4]
            new object[] { new ListNode(1) {next = new ListNode(2) {next = new ListNode(3) {next = new ListNode(4) { next = new ListNode(5) }}}}, 4, 5,
                           new ListNode(1) {next = new ListNode(2) {next = new ListNode(3) {next = new ListNode(5) { next = new ListNode(4) }}}} },
            //[1,2,3,4,5,6] 1 6 [6,5,4,3,2,1]
            new object[] { new ListNode(1) {next = new ListNode(2) {next = new ListNode(3) {next = new ListNode(4) { next = new ListNode(5) { next = new ListNode(6) }}}}}, 1, 6,
                           new ListNode(6) {next = new ListNode(5) {next = new ListNode(4) {next = new ListNode(3) { next = new ListNode(2) { next = new ListNode(1) }}}}} },
            //[1,2,3,4,5,6,7] 1 2 [2,1,3,4,5,6,7]
            new object[] { new ListNode(1) {next = new ListNode(2) {next = new ListNode(3) {next = new ListNode(4) { next = new ListNode(5) { next = new ListNode(6) { next = new ListNode(7)}}}}}}, 1, 2,
                           new ListNode(2) {next = new ListNode(1) {next = new ListNode(3) {next = new ListNode(4) { next = new ListNode(5) { next = new ListNode(6) { next = new ListNode(7)}}}}}} },
            //[1,2,3,4,5,6,7,8] 3 6 [1,2,6,5,4,3,7,8]
            new object[] { new ListNode(1) {next = new ListNode(2) {next = new ListNode(3) {next = new ListNode(4) { next = new ListNode(5) { next = new ListNode(6) { next = new ListNode(7) { next = new ListNode(8)}}}}}}}, 3, 6,
                           new ListNode(1) {next = new ListNode(2) {next = new ListNode(6) {next = new ListNode(5) { next = new ListNode(4) { next = new ListNode(3) { next = new ListNode(7) { next = new ListNode(8)}}}}}}} },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(ListNode head, int m, int n, ListNode expected)
        {
            var sol = new Solution();
            var res = sol.ReverseBetween(head, m, n);

            while(res != null)
            {
                Assert.That(res.val == expected.val);
                res = res.next;
                expected = expected.next;
            }
            
            Assert.That(expected, Is.Null);
        }
    }
}