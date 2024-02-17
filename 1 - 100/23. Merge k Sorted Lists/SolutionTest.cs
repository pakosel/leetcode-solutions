using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace MergeKsortedLists
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            //[[1,4,5],[1,3,4],[2,6]], [1,1,2,3,4,4,5,6]
            new object[] { new ListNode[] { new ListNode(1) {next = new ListNode(4) {next = new ListNode(5)}}, 
                                            new ListNode(1) {next = new ListNode(3) {next = new ListNode(4)}},
                                            new ListNode(2) {next = new ListNode(6)}},
                           new ListNode(1) {next = new ListNode(1) {next = new ListNode(2) {next = new ListNode(3) { next = new ListNode(4) { next = new ListNode(4) { next = new ListNode(5) { next = new ListNode(6)}}}}}}} },
            //[[],[-2],[-3,-2,1]], [-3, -2, -2, 1]
            new object[] { new ListNode[] { null, new ListNode(-2), new ListNode(-3) {next = new ListNode(-2) { next = new ListNode(1)}} },
                           new ListNode(-3) {next = new ListNode(-2) {next = new ListNode(-2) {next = new ListNode(1)}}} },
            //[], null
            new object[] { new ListNode[0], null }
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(ListNode[] lists, ListNode expected)
        {
            var sol = new Solution();
            var res = sol.MergeKLists(lists);

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