using System.Collections.Generic;
using System.Linq;
using System;

namespace FourSum
{
    public class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            int len = nums.Length;
            Array.Sort(nums);

            IList<IList<int>> ret = new List<IList<int>>();
            for (int i = 0; i < len-3; i++)
                for (int j = i + 1; j < len-2; j++)
                {
                    var sum = nums[i] + nums[j];
                    var lookingFor = target - sum;
                    int left = j + 1;
                    int right = len - 1;
                    while (left < right)
                    {
                        if (nums[left] + nums[right] > lookingFor)
                            right--;
                        else if (nums[left] + nums[right] < lookingFor)
                            left++;
                        else //if(nums[left] + nums[right] == lookingFor)
                        {
                            var newList = new List<int> { nums[i], nums[j], nums[left], nums[right] };
                            if(ret.All(l => !this.EqualLists(l, newList)))
                                ret.Add(newList);
                            left++;
                            right--;
                        }
                    }
                }

            return ret;
        }

        private bool EqualLists(IList<int> l1, IList<int> l2) => l1[0] == l2[0] && l1[1] == l2[1] && l1[2] == l2[2] && l1[3] == l2[3];
    }
}