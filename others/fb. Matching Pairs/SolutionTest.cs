using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace MatchingPairs
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("abcd", "adcb", 4)]
        [TestCase("mno", "mno", 1)]     //test case no. 2
        [TestCase("acbd", "adbc", 4)]
        [TestCase("acbdd", "adbec", 4)]
        [TestCase("acbe", "adbc", 3)]
        [TestCase("acbed", "adbcc", 4)]
        [TestCase("abcd", "xyzv", 0)]
        [TestCase("abcd", "ayzv", 1)]
        [TestCase("aabb", "aabb", 4)]   //test case no. 9
        [TestCase("bbaa", "aabb", 2)]
        public void Test_Examples(string s, string t, int expected)
        {
            var ret = Solution.matchingPairs(s, t);
            
            ClassicAssert.AreEqual(ret, expected);
        }
    }
}