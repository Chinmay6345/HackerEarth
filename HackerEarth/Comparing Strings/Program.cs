using System;
using System.Collections.Generic;
using System.Linq;

//https://www.hackerearth.com/problem/algorithm/comparing-strings-1/
/*You are given two strings, A and B. Find if there is a substring that appears in both A and B.

Input

The first line of the input will contain a single integer T, the number of test cases.

Then there will be T descriptions of the test cases. Each description contains two lines. The first line contains the string A and the second line contains the string B.

OUTPUT

For each test case, display YES (in a newline), if there is a common substring. Otherwise, display NO.

CONSTRAINTS

All the strings contain only lowercase Latin letters. 1<=T<=10 1<=|A|,|B|<=10^5

SAMPLE INPUT 
2
hello
world
hi
world*/
namespace Comparing_Strings
{
    public static class AppHelper
    {
        public static void CompareStrings(List<String> lst)
        {
            if (lst.ElementAt(0).Intersect(lst.ElementAt(1)).Any())
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Convert.ToInt32(Console.ReadLine());
            Int32 k = n * n;
            List<String> lst = new List<String>();
            for (Int32 i = 0; i < k; i++)
            {
                String str = Console.ReadLine();
                if (!String.IsNullOrEmpty(str))
                {
                    lst.Add(str);
                }
                if (lst.Count() == 2)
                {
                    AppHelper.CompareStrings(lst);
                    lst.Clear();
                }
            }
        }
    }
}
