using System;
using System.Collections.Generic;
using System.Text;

/*
 * Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
 * Symbol       Value
 * I             1
 * V             5
 * X             10
 * L             50
 * C             100
 * D             500
 * M             1000
 * 
 * public int RomanToInt(string s)
 * 
 */

namespace LeetCode.Easy.RomanToInteger
{
    static class RomanIntegerNaive
    {
        public static void Run(string input = "MMMCMXCIX")
        {
            Console.WriteLine("Starting Naive RomanToInt");

            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Result: {RomanToInt(input)}");

            Console.WriteLine("Ending");
        }
        private static int CharToInt(char c)
        {
            return (Char.ToLower(c)) switch
            {
                'i' => 1,
                'v' => 5,
                'x' => 10,
                'l' => 50,
                'c' => 100,
                'd' => 500,
                'm' => 1000,
                _ => throw new Exception("Not a valid Roman Numeral"),
            };
        }
        public static int RomanToInt(string input)
        {
            Queue<int> intQueue = new Queue<int>();
            int sum = 0;

            foreach (char c in input)
                intQueue.Enqueue(CharToInt(c));
            
            while(intQueue.Count > 1)
            {
                int current = intQueue.Dequeue();
                if (current < intQueue.Peek())
                    sum -= current;
                else
                    sum += current;
            }
            return sum + intQueue.Dequeue();
        }
    }
}
