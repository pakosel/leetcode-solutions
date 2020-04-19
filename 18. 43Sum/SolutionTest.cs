using System.Text;
using NUnit.Framework;
using System.Linq;

namespace FourSum
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("[1,0,-1,0,-2,2]", 0, "[[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]")]
        [TestCase("[0,0,0,0]", 1, "[]")]
        [TestCase("[-3,-2,-1,0,0,1,2,3]", 0, "[[-3,-2,2,3],[-3,-1,1,3],[-3,0,0,3],[-3,0,1,2],[-2,-1,0,3],[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]")]
        public void Test_Examples(string input, int target, string expected)
        {
            var arr = input.TrimStart('[').TrimEnd(']').Split(',');
            var nums = new int[arr.Length];
            for(int i=0; i<arr.Length; i++)
                nums[i] = int.Parse(arr[i]);
            var sol = new Solution();
            var ret = sol.FourSum(nums, target);

            StringBuilder sb = new StringBuilder();
            sb.Append('[');
            sb.Append(string.Join(',', ret.Select(it => "[" + string.Join(',', it) + "]")));
            sb.Append(']');
            
            Assert.AreEqual(sb.ToString(), expected);
        }
    }
}