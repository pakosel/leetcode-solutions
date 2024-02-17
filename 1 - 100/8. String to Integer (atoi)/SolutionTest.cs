using NUnit.Framework;

namespace StringToInteger
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"42", 42},
            new object[] {"3.14159", 3},
            new object[] {"   -42", -42},
            new object[] {"4193 with words", 4193},
            new object[] {"words and 987", 0},
            new object[] {"-91283472332", -2147483648},
            new object[] {"  +- 42", 0},
            new object[] {"00000-42a1234", 0},
            new object[] {"  +000 42", 0},
            new object[] {"  +  413", 0},
            new object[] {"9223372036854775808", 2147483647},
            new object[] {"-9223372036854775808", -2147483648},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Examples(string str, int expected)
        {
            var sol = new Solution();
            var ret = sol.MyAtoi(str);
            
            Assert.That(expected == ret);
        }
    }
}