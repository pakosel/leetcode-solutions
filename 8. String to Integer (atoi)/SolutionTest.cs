using NUnit.Framework;

namespace Atoi
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("42", 42)]
        [TestCase("   -42", -42)]
        [TestCase("4193 with words", 4193)]
        [TestCase("words and 987", 0)]
        [TestCase("-91283472332", -2147483648)]
        public void Test_Examples(string str, int expected)
        {
            var sol = new Solution();
            var ret = sol.MyAtoi(str);
            
            Assert.AreEqual(ret, expected);
        }
    }
}