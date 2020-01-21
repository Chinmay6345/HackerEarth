using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monk_Teaches_Palindrome
{
    //https://www.hackerearth.com/practice/algorithms/string-algorithm/basics-of-string-manipulation/practice-problems/algorithm/monk-teaches-palindrome/
    public static class AppHelper
    {
        public static void PalindromeString(List<String> lstInput)
        {
            foreach (String inputstring in lstInput)
            {
                String temp = inputstring;
                String oddeven = temp.Length % 2 == 0 ? "EVEN" : "ODD";
                Char[] array = inputstring.ToCharArray();
                Array.Reverse(array);
                String reversedstring = new String(array);
                if (reversedstring.Equals(temp))
                {
                    Console.WriteLine("YES" + " " + oddeven);
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            List<String> lstString = new List<String>();
            Int32 n = Int32.Parse(Console.ReadLine());
            for (Int32 i = 0; i < n; i++)
            {
                String input = Console.ReadLine();
                lstString.Add(input);
            }
            AppHelper.PalindromeString(lstString);
        }
    }
}
