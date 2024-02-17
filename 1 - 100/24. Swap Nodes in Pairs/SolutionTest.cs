using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace SwapNodesInPairs
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { null, null },
            //[1] [1]
            new object[] { new ListNode(1),
                           new ListNode(1) },
            //[1,2] [2,1]
            new object[] { new ListNode(1) {next = new ListNode(2) },
                           new ListNode(2) {next = new ListNode(1) } },
            //[1,2,3,4] [2,1,4,3]
            new object[] { new ListNode(1) {next = new ListNode(2) {next = new ListNode(3) {next = new ListNode(4) }}},
                           new ListNode(2) {next = new ListNode(1) {next = new ListNode(4) {next = new ListNode(3) }}} },
            //[1,2,3,4,5] [2,1,4,3,5]
            new object[] { new ListNode(1) {next = new ListNode(2) {next = new ListNode(3) {next = new ListNode(4) { next = new ListNode(5) }}}},
                           new ListNode(2) {next = new ListNode(1) {next = new ListNode(4) {next = new ListNode(3) { next = new ListNode(5) }}}} },
            //[1,2,3,4,5,6] [2,1,4,3,6,5]
            new object[] { new ListNode(1) {next = new ListNode(2) {next = new ListNode(3) {next = new ListNode(4) { next = new ListNode(5) { next = new ListNode(6) }}}}},
                           new ListNode(2) {next = new ListNode(1) {next = new ListNode(4) {next = new ListNode(3) { next = new ListNode(6) { next = new ListNode(5) }}}}} },
            //[1,2,3,4,5,6,7] [2,1,4,3,6,5,7]
            new object[] { new ListNode(1) {next = new ListNode(2) {next = new ListNode(3) {next = new ListNode(4) { next = new ListNode(5) { next = new ListNode(6) { next = new ListNode(7)}}}}}},
                           new ListNode(2) {next = new ListNode(1) {next = new ListNode(4) {next = new ListNode(3) { next = new ListNode(6) { next = new ListNode(5) { next = new ListNode(7)}}}}}} },
            //[1,2,3,4,5,6,7,8] [2,1,4,3,6,5,8,7]
            new object[] { new ListNode(1) {next = new ListNode(2) {next = new ListNode(3) {next = new ListNode(4) { next = new ListNode(5) { next = new ListNode(6) { next = new ListNode(7) { next = new ListNode(8)}}}}}}},
                           new ListNode(2) {next = new ListNode(1) {next = new ListNode(4) {next = new ListNode(3) { next = new ListNode(6) { next = new ListNode(5) { next = new ListNode(8) { next = new ListNode(7)}}}}}}} },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(ListNode head, ListNode expected)
        {
            var sol = new Solution();
            var res = sol.SwapPairs(head);

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