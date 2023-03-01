using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SortAnArray
{
    public class Solution
    {
        const int TRESHOLD = 100;
        public int[] SortArray(int[] nums)
        {
            MergeSort(nums, 0, nums.Length - 1);

            return nums;
        }

        private void MergeSort(int[] nums, int start, int end)
        {
            if (end - start < TRESHOLD)
            {
                BubbleSort(nums, start, end);
                return;
            }
            var mid = start + (end - start) / 2;

            MergeSort(nums, start, mid);
            MergeSort(nums, mid + 1, end);

            Merge(nums, start, end, mid);
        }

        private void Merge(int[] nums, int start, int end, int mid)
        {
            var temp = new int[end-start+1];
            int i1 = start, i2 = mid+1;
            int i=0;
            while(i < temp.Length)
                if(i2 > end || (i1 <= mid && nums[i1] < nums[i2]))
                    temp[i++] = nums[i1++];
                else
                    temp[i++] = nums[i2++];
            for(i=0; i<temp.Length; i++)
                nums[start+i] = temp[i];
        }

        private void BubbleSort(int[] nums, int start, int end)
        {
            for (int i = start; i < end; i++)
                for (int j = i + 1; j <= end; j++)
                    if (nums[j] < nums[i])
                        (nums[i], nums[j]) = (nums[j], nums[i]);
        }
    }
}