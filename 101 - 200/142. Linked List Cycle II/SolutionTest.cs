using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LinkedListCycleII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[3,2,0,-4]", 1},
            new object[] {"[1,2]", 0},
            new object[] {"[1]", -1},
            new object[] {"[1,1,1,1,1]", 2},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string list, int pos)
        {
            var head = ListNodeHelper.BuildList(list);
            var expected = head;
            if(pos == -1)
                expected = null;
            else
            {
                for(int i=0; i<pos; i++)
                    expected = expected.next;
                ListNodeHelper.Tail(head).next = expected;
            }

            var sol = new Solution();
            var res = sol.DetectCycle(head);

            Assert.That(expected == res);
        }
    }
}