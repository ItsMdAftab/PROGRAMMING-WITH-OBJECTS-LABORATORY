using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        string s = Console.ReadLine(); 
        Stack<int> stack = new Stack<int>();
        foreach(char a in s)
        {
            if (a == '(')
            {
                stack.Push(a);
            }
            else if (a == ')')
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("false");
                }
                stack.Pop();
            }

        }
        if (stack.Count == 0)
        {
            Console.WriteLine("true");
        }


        

    }
}