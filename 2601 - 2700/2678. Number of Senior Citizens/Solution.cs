using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NumberOfSeniorCitizens
{
    public class Solution
    {
        public int CountSeniors(string[] details) =>
            details.Count(p => int.Parse(p[11..13]) > 60);
    }
}