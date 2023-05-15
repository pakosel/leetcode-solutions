using System.Collections.Generic;
using System.Linq;
using System;
using Common;

namespace RotateArray
{
    public class Solution_Basic
    {
        public void Rotate(int[] nums, int k)
        {
            var len = nums.Length;
            var res = new int[len];
            k = k % len;
            for (int i = 0; i < len; i++)
                res[(i + k) % len] = nums[i];
            Array.Copy(res, nums, len);
        }
    }
    public class Solution_O_k
    {
        public void Rotate(int[] nums, int k)
        {
            var len = nums.Length;
            k = k % len;
            if (k == 0)
                return;
            var temp = new int[k];
            int i = 0;
            int j = 0;
            while (i < k)
                temp[i] = nums[i++];
            while (i != k - 1)
            {
                (nums[i], temp[j]) = (temp[j], nums[i]);
                i = (i + 1) % len;
                j = (j + 1) % k;
            }
            nums[k - 1] = temp[j];
        }
    }

    public class Solution_O_1
    {
        public void Rotate(int[] nums, int k)
        {
            var len = nums.Length;
            k = k % len;
            if (k == 0)
                return;
            var temp = 0;
            var i = 0;
            var gcd = MathExt.Gcd(len, k);
            for (int j = 0; j < gcd; j++)
            {
                temp = nums[j];
                i = j + k;
                while (i != j)
                {
                    (nums[i], temp) = (temp, nums[i]);
                    i = (i + k) % len;
                }
                nums[i] = temp;
            }
        }
    }
}