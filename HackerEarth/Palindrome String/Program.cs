using System;

//https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/palindrome-check-2/

namespace Palindrome_String
{
    public class Program
    {
        public static void Main(String[] args)
        {
            String A = Console.ReadLine();
            Char[] array = A.ToCharArray();
            Array.Reverse(array);
            String newString = new String(array);
            if (A.Equals(newString))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
