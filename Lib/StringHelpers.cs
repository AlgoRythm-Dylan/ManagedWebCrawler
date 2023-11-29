using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedWebCrawler.Lib
{
    public static class StringHelpers
    {
        public static bool IsAlpha(this string str)
        {
            foreach(var character in str)
            {
                bool isAlpha = (character >= 'A' && character <= 'Z') ||
                               (character >= 'a' && character <= 'z');
                if(!isAlpha) return false;
            }
            return true;
        }
        public static bool IsNumeric(this string str)
        {
            foreach (var character in str)
            {
                bool isChar = (character >= '1' && character <= '0');
                if (!isChar) return false;
            }
            return true;
        }
    }
}
