using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.NumberPalindrome
{
    static class NumberPalindromeNaive
    {
        public static void Run()
        {
            Console.WriteLine("Starting Naive NumberPalindrome");
            int input = -678909876;

            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Result: {IsPalindrome(input)}");
            Console.WriteLine("Ending");
        }

        public static bool IsPalindrome(int input)
        {
            string inputString = Math.Abs(input).ToString();
            int inputLength = inputString.Length;

            for (int i = 0; i < inputLength / 2; i++)
            {
                Console.WriteLine($"{inputString[i]} == {inputString[(inputLength - 1) - i]}");
                if (inputString[i] != inputString[(inputLength - 1) - i])
                    return false;
            }
            return true;
        }
    }
}
