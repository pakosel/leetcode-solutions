using NUnit.Framework;

namespace LongestSubstringWithoutRepeatingCharacters
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Test_Simple()
        {
            var solution = new Solution();
            var ret = solution.LengthOfLongestSubstring("abcabcbb");

            Assert.AreEqual(ret, 3);
        }

        [Test]
        public void Test_Tricky()
        {
            var solution = new Solution();
            var ret = solution.LengthOfLongestSubstring("abcddcba");

            Assert.AreEqual(ret, 4);
        }

        [Test]
        public void Test_Complex()
        {
            var solution = new Solution();
            var ret = solution.LengthOfLongestSubstring("axwabcdefgahij");

            Assert.AreEqual(ret, 10);
        }
    }
}