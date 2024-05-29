using System.Collections.Generic;
using System.Linq;
using System;

namespace NumberOfStepsToReduceNumberInBinaryRepresentationToOne
{
    public class Solution
    {
        public int NumSteps(string s)
        {
            var arr = s.ToCharArray();
            int res = 0, left = 0, right = s.Length - 1;

            while (right > left)
            {
                if (arr[right] == '1')
                    Add();
                else
                    Div();
                res++;
            }


            void Div()
            {
                right--;
            }

            void Add()
            {
                arr[right] = '0';
                int i = right - 1;
                while (i >= left && arr[i] == '1')
                    arr[i--] = '0';

                if (i < left)
                    if (left == 0)
                    {
                        arr[left] = '1';
                        res++;
                    }
                    else
                        arr[--left] = '1';
                else
                    arr[i] = '1';
            }

            return res;
        }
    }
}