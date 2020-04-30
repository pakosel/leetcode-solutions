using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace CloneGraph
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("[[2,4],[1,3],[2,4],[1,3]]", "[[2,4],[1,3],[2,4],[1,3]]")]
        public void Test_Example(string input, int expected)
        {
            //TODO
            
            Assert.AreEqual(input, expected);
        }
    }
}