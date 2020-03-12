using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.hackerearth.com/practice/algorithms/string-algorithm/basics-of-string-manipulation/practice-problems/algorithm/chotu-and-palindromic-strings/
/*
Everyone knows that chotu likes palindromic strings. One day, he found 2 ordinary strings s1 and s2. Now he wonders if he could make a palindrome by concatenating s1 and s2 in any order. i.e if s1s2 or s2s1 is a palindrome.

Input
First line of input contains T, denoting number of test cases.
Each test case contains two lines, first line contains string s1 and second line contains string s2.

Output
Print T lines, either "YES" or "NO"(without quotes).

Constrains
1 <= T <= 1000
1 <= |s1|, |s2| <= 10000
Both strings contain only lower case letters.

SAMPLE INPUT 
2
aba
baba
xy
zw
SAMPLE OUTPUT 
YES
NO 
*/
namespace Chotu_and_Palindromic_Strings
{
    public static class AppHelper
    {
        public static void MakeCombinations(List<String> lst)
        {
            try
            {
                for (int i = 0; i < lst.Count() - 1; i++)
                {
                    if (i < lst.Count())
                    {
                        String first = lst[i] + lst[i + 1];
                        String second = lst[i + 1] + lst[i];
                        i++;
                        Palindrome(first, second);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message =" + ex.Message);
            }

        }
        public static void Palindrome(String first, String second)
        {
            try
            {
                Char[] chr1 = first.ToCharArray();
                Array.Reverse(chr1);
                Char[] chr2 = second.ToCharArray();
                Array.Reverse(chr2);
                if (new String(chr1) == first || new String(chr2) == second)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            catch (Exception)
            {
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
                Int32 NoOfElements = Convert.ToInt32(Console.ReadLine());
                List<String> lst = new List<String>();
                for (Int32 i = 0; i < (NoOfElements * NoOfElements); i++)
                {
                    String str = Console.ReadLine();
                    if (!String.IsNullOrEmpty(str))
                    {
                        lst.Add(str);
                    }
                }
                AppHelper.MakeCombinations(lst);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
