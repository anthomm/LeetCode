using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Given a 32-bit signed integer, reverse digits of an integer.
 * 
 * Input: 123
 * Output: 321
 * 
 * Input: -123
 * Output: -321
 * 
 * Assume we are dealing with an environment which could only store integers within 
 * the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, 
 * assume that your function returns 0 when the reversed integer overflows.
 * 
 * public int Reverse(int x)
 */

namespace LeetCode.ReverseInteger
{
    static class ReverseIntegerNaive
    {
        /*
         * int[] inputs = new int[] { 123, -123, 120, Int32.MaxValue, Int32.MinValue };
         * foreach (int i in inputs)
         *      ReverseIntegerNaive.Run(i);
         */
        public static void Run(int input = -120)
        {
            Console.WriteLine("Starting Reverse Integer");
            int result = ReverseInteger(input);

            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Ending");
        }

        public static int ReverseInteger(int input)
        {
            if (input == Int32.MinValue) // Guard against abs on MinVal
                return 0;
            
            bool isNegative = input < 0;
            
            string inputString = Math.Abs(input).ToString();
            string reversedString = StringHelper.ReverseString(inputString);


            if (Int32.TryParse(reversedString, out int buffer))
            {
                if (isNegative)
                {
                    return buffer * -1;
                }
                else
                {
                    return buffer;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
