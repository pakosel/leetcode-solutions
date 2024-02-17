using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace IntersectionOfTwoLinkedLists
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {8, "[4,1,8,4,5]", "[5,6,1,8,4,5]", 2, 3},
            new object[] {2, "[1,9,1,2,4]", "[3,2,4]", 3, 1},
            new object[] {0, "[2,6,4]", "[1,5]", 3, 2},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Naive(int intersectVal, string listAStr, string listBStr, int skipA, int skipB)
        {
            Test_Generic<Solution>(() => new Solution(), intersectVal, listAStr, listBStr, skipA, skipB);
        }
        [Test]
        [TestCaseSource("testCases")]
        public void Test_Smart(int intersectVal, string listAStr, string listBStr, int skipA, int skipB)
        {
            Test_Generic<Solution_Smart>(() => new Solution_Smart(), intersectVal, listAStr, listBStr, skipA, skipB);
        }

        public void Test_Generic<T>(Func<ISolution> constructor, int intersectVal, string listAStr, string listBStr, int skipA, int skipB) 
            where T : ISolution
        {
            var listA = ListNodeHelper.BuildList(listAStr);
            var listB = ListNodeHelper.BuildList(listBStr);
            if(intersectVal != 0)
            {
                var a = listA;
                var b = listB;
                var skA = skipA;
                var skB = skipB;
                while(skA-- > 0)
                    a = a.next;
                while(skB-- > 1)
                    b = b.next;
                b.next = a;
            }

            var sol = constructor();
            var res = sol.GetIntersectionNode(listA, listB);
            if(intersectVal == 0)
                Assert.That(res, Is.Null);
            else
            {
                Assert.That(intersectVal == res?.val);
                while(skipA-- > 0)
                    listA = listA.next;
                while(skipB-- > 0)
                    listB = listB.next;
                Assert.That(res == listA);
                Assert.That(res == listB);
            }
        }
    }
}