using System;
using System.Linq;

//https://www.hackerearth.com/problem/algorithm/alphanumeric-strings/

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
