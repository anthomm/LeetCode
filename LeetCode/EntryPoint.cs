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
            Console.WriteLine("T");
            ValidParenthesesNaive.Run("()"); // T
            Console.WriteLine();

            Console.WriteLine("T");
            ValidParenthesesNaive.Run("()()"); // T
            Console.WriteLine();

            Console.WriteLine("T");
            ValidParenthesesNaive.Run("[]{}()"); // T
            Console.WriteLine();

            Console.WriteLine("T");
            ValidParenthesesNaive.Run("([{}])"); // T
            Console.WriteLine();

            Console.WriteLine("F");
            ValidParenthesesNaive.Run("([)]"); // F
            Console.WriteLine();

            Console.WriteLine("F");
            ValidParenthesesNaive.Run("({[])}"); // F
            Console.WriteLine();

            Console.WriteLine("F");
            ValidParenthesesNaive.Run("((())"); // F
            Console.WriteLine();
        }
    }
}
