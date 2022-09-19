using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FindDuplicateFileInSystem
{
    public class Solution
    {
        public IList<IList<string>> FindDuplicate(string[] paths)
        {
            var dict = new Dictionary<int, IList<string>>();
            foreach (var dir in paths)
            {
                var arr = dir.Split(' ');
                var root = arr[0];
                foreach (var file in arr.Skip(1))
                {
                    var fileArr = file.Split('(');
                    var path = root + '/' + fileArr[0];
                    var content = fileArr[1].TrimEnd(')');
                    if (!dict.ContainsKey(content.GetHashCode()))
                        dict.Add(content.GetHashCode(), new List<string>());
                    dict[content.GetHashCode()].Add(path);
                }
            }

            return dict.Where(kvp => kvp.Value.Count > 1).Select(kvp => kvp.Value).ToList();
        }
    }
}