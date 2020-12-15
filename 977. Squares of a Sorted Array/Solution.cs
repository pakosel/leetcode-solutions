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
            int first = 0;
            for(int i=0; i<nums.Length; i++)
            {
                nums[i] *= nums[i];
                if(nums[i] <= nums[first])
                    first = i;
            }
            
            int[] res = new int[nums.Length];
            int idx = 0;
            int lp = first;
            int rp = first+1;
            while(lp >= 0 || rp < nums.Length)
            {
                int left = lp >= 0 ? nums[lp] : int.MaxValue;
                int right = rp < nums.Length ? nums[rp] : int.MaxValue;
                res[idx++] = left < right ? nums[lp--] : nums[rp++];
            }
            
            return res;
        }
    }

    public class Solution_Naive
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