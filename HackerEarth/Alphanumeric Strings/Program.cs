using System;
using System.Linq;

//https://www.hackerearth.com/problem/algorithm/alphanumeric-strings/

/*You are given a string which consists of lowercase, uppercase alphabets and numbers in it. Such strings are called alphanumeric strings.

Your task is simple, you just need to separate the numbers from the alphanumeric string and output their sum.*/

namespace Alphanumeric_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            String InputString = Console.ReadLine();
            Console.WriteLine(InputString.Where(a=>Char.IsNumber(a)).Select(a => a - '0').ToArray().Sum());
        }
    }
}
