using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;

namespace FourSum
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("[1,0,-1,0,-2,2]", 0, "[[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]")]
        [TestCase("[0,0,0,0]", 1, "[]")]
        [TestCase("[0,0,0,0]", 0, "[[0,0,0,0]]")]
        [TestCase("[-3,-2,-1,0,0,1,2,3]", 0, "[[-3,-2,2,3],[-3,-1,1,3],[-3,0,0,3],[-3,0,1,2],[-2,-1,0,3],[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]")]
        [TestCase("[-5,-4,-3,-2,-1,0,0,1,2,3,4,5]", 0, "[[-5,-4,4,5],[-5,-3,3,5],[-5,-2,2,5],[-5,-2,3,4],[-5,-1,1,5],[-5,-1,2,4],[-5,0,0,5],[-5,0,1,4],[-5,0,2,3],[-4,-3,2,5],[-4,-3,3,4],[-4,-2,1,5],[-4,-2,2,4],[-4,-1,0,5],[-4,-1,1,4],[-4,-1,2,3],[-4,0,0,4],[-4,0,1,3],[-3,-2,0,5],[-3,-2,1,4],[-3,-2,2,3],[-3,-1,0,4],[-3,-1,1,3],[-3,0,0,3],[-3,0,1,2],[-2,-1,0,3],[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]")]
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
            
            ClassicAssert.AreEqual(sb.ToString(), expected);
        }
    }
}