using System.Collections.Generic;
using System.Linq;
using System;

namespace ThreeSum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var outList = new List<IList<int>>();

            if(nums.Length < 3)
                return outList;
            
            Array.Sort(nums);

            Dictionary<int, int> values = new Dictionary<int, int>();
            var len = nums.Length;
            for (int i = len - 1; i >= 0; i--)
                if (!values.ContainsKey(nums[i]))
                    values.Add(nums[i], i);

            for (int i = 0; i < len; i++)
            {
                if(i > 0 && nums[i-1] == nums[i])
                    continue;
                for (int j = i + 1; j < len; j++)
                {
                    if(j > i + 1 && nums[j-1] == nums[j])
                        continue;

                    var sum = nums[i] + nums[j];
                    var lookingFor = -1 * sum;
                    if (values.ContainsKey(lookingFor))
                    {
                        var idx = values[lookingFor];
                        if(idx > i && idx > j)
                            outList.Add(new int[] { nums[i], nums[j], nums[idx] });
                    }
                }
            }

            return outList;
        }
    }
}