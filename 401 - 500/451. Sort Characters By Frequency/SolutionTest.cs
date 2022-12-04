using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SortCharactersByFrequency
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"a", "a"},
            new object[] {"Ab", "Ab"},
            new object[] {"avavav", "aaavvv"},
            new object[] {"tree", "eetr"},
            new object[] {"cccaaa", "cccaaa"},
            new object[] {"Aabb", "bbAa"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string expected)
        {
            var sol = new Solution();
            var res = sol.FrequencySort(s);

            Assert.AreEqual(expected, res);
        }
    }
}