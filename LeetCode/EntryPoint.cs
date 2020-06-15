using LeetCode.Easy.LongestCommonPrefix;
using LeetCode.Easy.RomanToInteger;
using LeetCode.Easy.ValidParantheses;
using LeetCode.Helpers;
using LeetCode.NumberPalindrome;
using LeetCode.ReverseInteger;
using LeetCode.TwoSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            ValidParenthesesNaive.Run("()");
            Console.WriteLine();
            ValidParenthesesNaive.Run("()[]{}");
            Console.WriteLine();
            ValidParenthesesNaive.Run("(]");
            Console.WriteLine();
            ValidParenthesesNaive.Run("{([)]}");
        }
    }
}
