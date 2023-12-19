using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DestinationCity
{
    public class Solution
    {
        public string DestCity(IList<IList<string>> paths) =>
            paths.First(route => !paths.Any(r => r[0] == route[1]))[1];
    }
}