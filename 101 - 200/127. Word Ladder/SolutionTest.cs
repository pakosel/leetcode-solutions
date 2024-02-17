using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace WordLadder
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"hit", "cog", new string[] {"hot","dot","dog","lot","log","cog"}, 5},
            new object[] {"hit", "cog", new string[] {"hot","dot","dog","lot","log","cog","hit"}, 5},
            new object[] {"hit", "cog", new string[] {"hot","dot","dog","lot","log"}, 0},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Example(string beginWord, string endWord, string[] wordList, int expected)
        {
            var sol = new Solution();
            var ret = sol.LadderLength(beginWord, endWord, wordList.ToList());

            Assert.That(expected == ret);
        }
    }
}