// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class FizzBuzz
{
    static void solution(int start, int end)
    {
        for (int i = start; i < end; i++)
        {
            string res = string.Empty;

            if (i % 3 == 0)
            {
                res += "Fizz";
            }
            if (i % 5 == 0)
            {
                res += "Buzz";
            }

            res = res == string.Empty ? "Empty" : res;

            Console.WriteLine(res);
        }
    }

    public static void Main()
    {
        solution(1, 100);
    }
}