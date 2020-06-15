using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.ValidParantheses
{
    static class ValidParenthesesNaive
    {
        public static void Run(string input = "()[]{}")
        {
            Console.WriteLine("Starting Naive ValidParantheses");

            Console.WriteLine($"Input: {input}");

            bool result = IsValid(input);
            
            Console.WriteLine($"Result: {result}");
        }
        
        public static bool IsValid(string input)
        {
            Queue<char> charQueue = new Queue<char>();
            int balance = 0;
            
            foreach (char c in input)
            {
                balance += LeftOrRight(c);
                charQueue.Enqueue(c);
            }

            if (balance != 0)
                return false;

            while (charQueue.Count>1)
                if (IsStepIllegal(charQueue.Dequeue(), charQueue.Peek()))
                    return false;
            
            return true;
        }

        private static int LeftOrRight(char input)
        {
            switch (input)
            {
                case '(':
                case '{':
                case '[':
                    return 1;

                case ')':
                case '}':
                case ']':
                    return -1;

                default:
                    throw new Exception("Invalid LeftOrRight input.");
            }
        }

        private static bool IsStepIllegal(char current, char next)
        {
            return (current, next) switch
            {
                ('(', '}') => true,
                ('(', ']') => true,

                ('{', ')') => true,
                ('{', ']') => true,

                ('[', ')') => true,
                ('[', '}') => true,

                _ => false
            };
        }
    }
}
