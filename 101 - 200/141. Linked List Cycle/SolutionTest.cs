using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LinkedListCycle
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[3,2,0,-4]", 1, true},
            new object[] {"[1,2]", 0, true},
            new object[] {"[1]", -1, false},
            new object[] {"[1]", 0, true},
            new object[] {"[]", -1, false},
            new object[] {"[1,1,1]", 1, true},
            new object[] {"[1,2,3]", 0, true},
            new object[] {"[1,2,3,4]", 0, true},
            new object[] {"[1,2,3,4,5]", 0, true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic23(string listStr, int loopIdx, bool expected)
        {
            var head = ListNodeHelper.BuildList(listStr);
            MakeLoop(head, loopIdx);

            var sol = new Solution_2023();
            var res = sol.HasCycle(head);

            Assert.AreEqual(expected, res);
        }
        
        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string listStr, int loopIdx, bool expected)
        {
            var head = ListNodeHelper.BuildList(listStr);
            MakeLoop(head, loopIdx);

            var sol = new Solution();
            var res = sol.HasCycle(head);

            Assert.AreEqual(expected, res);
        }
        
        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic_O1(string listStr, int loopIdx, bool expected)
        {
            var head = ListNodeHelper.BuildList(listStr);
            MakeLoop(head, loopIdx);

            var sol = new Solution_O1();
            var res = sol.HasCycle(head);

            Assert.AreEqual(expected, res);
        }

        private void MakeLoop(ListNode head, int loopIdx)
        {
            if(loopIdx != -1)
            {
                var curr = head;
                while(loopIdx-- > 0)
                    curr = curr.next;
                var tail = curr;
                while(tail.next != null)
                    tail = tail.next;
                tail.next = curr;
            }
        }
    }
}