using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MultiplyStrings
{
    public class Solution
    {
        public string Multiply(string num1, string num2)
        {
            var arr = new int[num1.Length+num2.Length];
            //Array.Fill(arr, 0);
            var shift = 0;

            for(int i = num1.Length - 1; i >= 0; i--)
            {
                var digit1 = num1[i] - '0';
                int carry = 0;
                int x = 0;
                for(int j = num2.Length - 1; j >= 0; j--, x++)
                {
                    var digit2 = num2[j] - '0';
                    var product = digit1 * digit2 + carry + arr[x + shift];
                    arr[x + shift] = product % 10;
                    carry = product / 10;
                }
                if(carry != 0)
                    arr[x + shift] = carry;
                shift++;
            }

            Array.Reverse(arr);

            bool start = true;
            var res = string.Empty;
            foreach(var c in arr)
                if(start && c == 0)
                    continue;
                else
                {
                    start = false;
                    res += c;
                }
            
            if(res == string.Empty)
                res = "0";
            
            return res;
        }

        /*private string SumBigNumbers(StringBuilder[] arr)
        {
            var res = new StringBuilder();
            
            var carry = 0;
            for(int idx = 0; idx < arr[arr.Length - 1].Length; idx++)
            {
                var sum = carry;
                foreach(var sb in arr)
                    if(idx < sb.Length)
                        sum += sb[idx] - '0';
                res.Insert(0, sum % 10);
                carry = sum / 10;
            }
            if(carry != 0)
                res.Insert(0, carry);

            return res.ToString();
        }*/
    }
}