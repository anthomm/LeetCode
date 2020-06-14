using System;

/*
 * Determine whether an integer is a palindrome.
 * An integer is a palindrome when it reads the same backward as forward.
 * 
 * Example:
 * Input: -121
 * Output: false
 * Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
 * 
 * public bool IsPalindrome(int x)
 */

namespace LeetCode.NumberPalindrome
{
    static class NumberPalindromeNaive
    {
        public static void Run(int input = -678909876)
        {
            Console.WriteLine("Starting Naive NumberPalindrome");

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
