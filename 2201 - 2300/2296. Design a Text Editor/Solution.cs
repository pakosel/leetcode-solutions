using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DesignTextEditor
{
    public class TextEditor
    {
        StringBuilder sb;
        int pos;
        
        public TextEditor()
        {
            sb = new StringBuilder(50);
            pos = 0;
        }

        public void AddText(string text)
        {
            if (pos == sb.Length)
                sb.Append(text);
            else
                sb.Insert(pos, text);
            pos += text.Length;
        }

        public int DeleteText(int k)
        {
            var len = Math.Min(k, pos);
            sb.Remove(pos - len, len);
            pos -= len;
            return len;
        }

        public string CursorLeft(int k)
        {
            pos = Math.Max(0, pos - k);
            return GetLeft();
        }

        public string CursorRight(int k)
        {
            pos = Math.Min(sb.Length, pos + k);
            return GetLeft();
        }

        private string GetLeft()
        {
            var len = Math.Min(10, pos);
            return sb.ToString(pos - len, len);
        }
    }
}