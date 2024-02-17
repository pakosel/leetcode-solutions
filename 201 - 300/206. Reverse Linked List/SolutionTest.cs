using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace ReverseLinkedList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { null, null },
            new object[] { new ListNode(1), new ListNode(1) },
            new object[] { new ListNode(1) {next = new ListNode(2) },
                           new ListNode(2) {next = new ListNode(1) } },
            new object[] { new ListNode(1) {next = new ListNode(2) {next = new ListNode(3) {next = new ListNode(4) }}},
                           new ListNode(4) {next = new ListNode(3) {next = new ListNode(2) {next = new ListNode(1) }}} },
            new object[] { new ListNode(1) {next = new ListNode(2) {next = new ListNode(3) {next = new ListNode(4) { next = new ListNode(5) { next = new ListNode(6) { next = new ListNode(7)}}}}}},
                           new ListNode(7) {next = new ListNode(6) {next = new ListNode(5) {next = new ListNode(4) { next = new ListNode(3) { next = new ListNode(2) { next = new ListNode(1)}}}}}} },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(ListNode head, ListNode expected)
        {
            var sol = new Solution();
            var res = sol.ReverseList(head);

            while(res != null)
            {
                ClassicAssert.AreEqual(res.val, expected.val);
                res = res.next;
                expected = expected.next;
            }
            
            ClassicAssert.IsNull(expected);
        }
    }
}