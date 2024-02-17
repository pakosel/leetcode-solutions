using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace ValidPalindrome
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("A man, a plan, a canal: Panama", true)]
        [TestCase("race car", true)]
        [TestCase("race a car", false)]
        public void Test_Example(string input, bool expected)
        {
            var sol = new Solution();
            var ret = sol.IsPalindrome(input);

            Assert.That(expected == ret);
        }
    }
}