using System;
using System.Text;

namespace LeetCode.Helpers
{
    static class StringHelper
    {
        public static string IntArrayToString(int[] array)
        {
            StringBuilder sb = new StringBuilder();

            foreach(int i in array)
                sb.Append($"{i} ");

            string returnee = sb.ToString();

            return returnee.Trim();
        }

        public static string ReverseString(string input)
        {
            char[] cArray = input.ToCharArray();
            Array.Reverse(cArray);
            return new string(cArray);
        }
    }
}
