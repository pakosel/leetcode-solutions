using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace SquaresOfSortedArray
{
    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                nums[i] *= nums[i];
            Array.Sort(nums);
            return nums;
        }
    }

    public class Solution_Parallel
    {
        public int[] SortedSquares(int[] nums)
        {
            Parallel.For(0, nums.Length, i => nums[i] *= nums[i]);
            Array.Sort(nums);
            return nums;
        }
    }
}