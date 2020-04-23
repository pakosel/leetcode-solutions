using NUnit.Framework;

namespace MatchingPairs
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("abcd", "adcb", 4)]
        [TestCase("mno", "mno", 1)]
        [TestCase("acbd", "adbc", 4)]
        [TestCase("acbdd", "adbec", 4)]
        [TestCase("acbe", "adbc", 3)]
        [TestCase("acbed", "adbcc", 4)]
        [TestCase("abcd", "xyzv", 0)]
        public void Test_Examples(string s, string t, int expected)
        {
            var ret = Solution.matchingPairs(s, t);
            
            Assert.AreEqual(ret, expected);
        }
    }
}