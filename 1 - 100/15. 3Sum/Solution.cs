using System.Collections.Generic;
using System.Linq;
using System;

namespace ThreeSum
{
    public class Solution
    {
        /* Approach 1 */
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

        /* Approach 2 */
        public IList<IList<int>> ThreeSum_better(int[] nums)
        {
            var outList = new List<IList<int>>();

            if (nums.Length < 3)
                return outList;

            Array.Sort(nums);

            var len = nums.Length;
            var sum = 0;
            for (int i = 0; i < len - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                int lookingFor = sum - nums[i];
                int start = i + 1;
                int end = len - 1;

                while (start < end)
                {
                    int currentSum = nums[start] + nums[end];
                    if (currentSum == lookingFor)
                    {
                        outList.Add(new int[] { nums[i], nums[start], nums[end] });
                        end--;
                        while (end > start && nums[end] == nums[end + 1]) end--; //skip duplicates
                        start++;
                        while (start < end && nums[start] == nums[start - 1]) start++; //skip duplicates
                    }
                    else if (currentSum > lookingFor)
                        end--;
                    else //if(currentSum < lookingFor)
                        start++;
                }
            }

            return outList;
        }
    }
}