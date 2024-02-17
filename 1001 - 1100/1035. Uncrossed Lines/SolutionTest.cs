using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace UncrossedLines
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,4,2]", "[1,2,4]", 2},
            new object[] {"[2,5,1,2,5]", "[10,5,2,1,5,2]", 3},
            new object[] {"[1,3,7,1,7,5]", "[1,9,2,5,1]", 2},
            new object[] {"[22,39,17,43,36,2,23,46,50,15,14,3,30,10,17,29,44,38,14,33,19,46,35,48,38,23,1,18,28,44,18,19,16,11,32,15,25,1,3,18,8,49,31,11,39,5,13,33,17,9,21,42,20,43,1,28,22,33,44,12,31,21,18,36,21,15,29,44,14,13,27,36,1,14,8,38,41,21,17,38,15,11,1,22,45,25,19,42,35,21,15,4,39,4,6,14,32,15,10,41,20,21,40,42,13,46,35,3,45,45,40,45,49,29,45,37,15,28,50,9,7,25,2,36,33,38,49,27,3,14,38,40,8,46,21,20,33,6,6,35,49,41,14,10,31,47,12,47,16,34,11,22,17,43,25,22,8,44,8,10,26,15,34,25,49,43,11,46,47,12,46,37,8,22,26,38,4,31,43,39,45,15,37,18,40,14,46,48,26,47,24,13,37,26,31,8,14,47,42,47,14,35,17,32,45,43,19,34,14,26,28,5,20,48,27,23,45,42,17,23,45,24,47,8,27,35,22,38,30,38,35,46,8,44,46,40,33,31,9,25,40,18,35,31,38,32,37,33,30,28,7,22,11,9,49,46,39,20,2,3,40,20,27,45,16,47,25,42,20,44,27,6,35,26,3,37,18,33,19,14,39,33,25,23,41,18,40,34,14,46,23,10,3,36,17,12,2,13,27,49,19,40,30,32,36,36,32,45,46,41,24,34,25,22,10,24,19,32,21,26,12,14,28,37,30,34,37,16,48,27,3,25,10,29,1,2,3,44,23,28,40,7,20,50,10,22,28,48,3,40,30,23,19,40,46,41,17,19,14,26,32,43,25,17,25,10,9,7,29,37,40,43,8,48,7,44,3,41,50,43,22,49,5,19,50,16,18,21,47,5,27,45,32,22,17,12,28,3,12,22,13,1,32,12,32,16,29,40,3,6,22,48,34,39,43,4,23,25,9,42,16,36,15,9,25,37,8,13,2,26,24,30,29,25,6,44,1,39,23,48,28,24,46,17,1,27,21,23,4,47,11,41,22,15,14,48,12,25,50,35,27,30,20,5,10,8,47,26,41,9,33,36,24,3,10,5,28,14,16,7,5,4,20,40,37,8,17,5,49,1,23,17,15,20,30,18,34,13,23,10]", "[22,38,28,28,8,26,42,43,45,22,34,40,45,36,7,25,22,13,40,8,21,26,6,25,37,10,16,29,19,44,50,50,12,37,5,3,33,23,9,26,32,2,8,36,47,47,38,44,22,1,8,13,16,18,31,14,50,10,14,29,3,50,20,48,41,9,5,8,42,6,13,14,18,27,34,15,44,34,17,34,9,11,22,5,19,50,31,9,40,48,25,50,7,25,7,2,14,48,5,26,47,37,37,2,12,39,31,10,32,35,36,39,19,31,27,8,49,1,29,26,39,18,50,41,30,10,10,41,10,1,6,29,33,48,24,24,18,22,30,11,5,7,50,23,2,40,47,34,27,50,42,18,35,41,11,21,43,34,34,8,41,20,36,13,23,20,39,26,16,45,1,45,37,34,42,36,35,28,22,22,34,35,19,50,6,10,34,19,8,42,25,45,9,9,2,1,45,38,43,33,8,30,3,24,22,5,25,5,26,31,13,28,16,5,47,7,9,20,8,49,33,20,39,26,33,4,45,49,24,37,40,22,3,17,33,47,37,32,49,16,34,24,28,25,14,39,21,9,41,39,10,14,26,46,11,28,32,14,11,20,7,43,29,10,3,46,17,29,39,1,33,21,44,6,40,18,2,10,32,43,6,3,33,42,20,32,31,4,46,23,21,22,41,19,6,14,32,38,23,29,1,11,44,41,30,27,44,48,19,12,33,7,9,7,27,8,14,19,34,22,45,49,21,33,47,37,45,17,30,31,1,1,4,4,3,49,39,39,44,41,47,31,17,48,21,13,27,32,1,17,11,3,35,32,11,41,39,19,41,17,15,25,3,26,50,30,35,37,40,7,25,37,9,21,41,8,15,36,14,35,35,1,19,3,40,12,15,17,45,38,27,45,22,15,43,11,15,18,1,31,16,25,34,48,44,44,45,5,2,17,16,5,45,9,10,11,9,27,16,6,34,5,22,27,45,11,9,50,11,32,17,5,33,18,13,13,22,22,43,11,9,3,13,46,4,16,33,14,8,18,33,33,50,36,13,16,17,8,20,14,37,5,49,32,7,28,49,16,48,23,12,30,9,50,28,10,23,31,25,14,4,12,9,9,28,25,17,6,28,12,48,42,34,33,1,6,21,30,42,18]", 123},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string nums1Str, string nums2Str, int expected)
        {
            var nums1 = ArrayHelper.ArrayFromString<int>(nums1Str);
            var nums2 = ArrayHelper.ArrayFromString<int>(nums2Str);

            var res = (new Solution()).MaxUncrossedLines(nums1, nums2);

            Assert.That(expected == res);
        }
    }
}