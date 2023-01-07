using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CategorizeBoxAccordingToCriteria
{
    public class Solution
    {
        public string CategorizeBox(int length, int width, int height, int mass)
        {
            var qt = 10_000;
            long vol = (long)length * (long)width * (long)height;
            var res = "";
            if (length >= qt || width >= qt || height >= qt || vol >= 1_000_000_000)
                res = "Bulky";
            if (mass >= 100)
                return res != "" ? "Both" : "Heavy";

            return res == "" ? "Neither" : res;
        }
    }
}