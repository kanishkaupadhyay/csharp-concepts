using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Parenthesis
    {
        static bool hasMatchingParenthesis(string input)
        {
            Stack<char> stack = new Stack<char>();
            for(int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if(current == '(')
                {
                    stack.Push(current);
                    continue;
                }
                if(current == ')')
                {
                    if(stack.Count > 0)
                    {
                        stack.Pop();
                    }else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(hasMatchingParenthesis("()(hello)"));
            System.Console.WriteLine(hasMatchingParenthesis("()(("));
        }
    }
}