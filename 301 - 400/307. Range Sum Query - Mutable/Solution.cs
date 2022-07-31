using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RangeSumQueryMutable
{
    public class NumArray
    {
        int[] Nums;
        int[] Sums; //prefix-sum buckets
        int Size;   //bucket size
        public NumArray(int[] nums)
        {
            Nums = nums;
            Size = (int)Math.Ceiling(Math.Sqrt(nums.Length));
            Sums = new int[(int)Math.Ceiling((double)nums.Length / Size)];
            int i = 0, j = 0;
            while (i < nums.Length)
            {
                Sums[j] += nums[i++];
                if (i % Size == 0)
                {
                    j++;
                    if (j < Sums.Length)
                        Sums[j] = Sums[j - 1];
                }
            }
        }

        public void Update(int index, int val)
        {
            var diff = Nums[index] - val;
            Nums[index] = val;
            for (int i = index / Size; i < Sums.Length; i++)
                Sums[i] -= diff;
        }

        public int SumRange(int left, int right)
        {
            if (left == right)
                return Nums[left];
            var lb = left / Size;
            var rb = right / Size - 1;
            if (rb < lb)    //same bucket - naive sum
                return SumNaive(left, right);

            var sum = (lb == 0 || lb == rb ? Sums[rb] : Sums[rb] - Sums[lb - 1]);
            //subtract values from the left bucket to the left of start index 
            for (int i = 1; i <= left % Size; i++)
                sum -= Nums[left - i];
            //add values from the right bucket index (up to the right position)
            for (int i = 0; i <= right % Size; i++)
                sum += Nums[right - i];
            return sum;
        }

        private int SumNaive(int left, int right)
        {
            var sum = 0;
            for (int i = left; i <= right; i++)
                sum += Nums[i];
            return sum;
        }
    }
}