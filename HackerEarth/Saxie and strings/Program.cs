using System;
//https://www.hackerearth.com/pt-br/problem/algorithm/saxie-and-strings/

/*Saxie is a programming enthusiast. He has always been amazed by the beauty of strings. He always dreams of going to Byteland and playing with strings. One day he had a nightmare that Dr. Evil had attacked the strings. When he came forward to protect the strings, Dr. Evil asked him if every substring of S has its reverse in the string. Dr. Evil promised him that he will leave Byteland forever if Saxie answers his question. Your task is to help Saxie in saving Byteland.

Input:

First line of the input contains T, the number of test cases. The next T lines contain a string each.

Output:

For each string S Print "YES" if every substring of S has its reverse in the string else print "NO".

Constraints:

1<=T<=10000 1<=|S|<=100

S contains only lower-case characters.

SAMPLE INPUT 
2
aba
ax*/
namespace Saxie_and_strings
{
    public static class AppHelper
    {
        public static void HasReverse(String str)
        {
            try
            {
                Char[] arr = str.ToCharArray();
                Array.Reverse(arr);
                if (new String(arr).Equals(str))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            try
            {
                Int32 n = Convert.ToInt32(Console.ReadLine());
                while (n != 0)
                {
                    AppHelper.HasReverse(Console.ReadLine());
                    n = n - 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
