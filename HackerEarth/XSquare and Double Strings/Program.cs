using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerearth.com/practice/data-structures/hash-tables/basics-of-hash-tables/practice-problems/algorithm/xsquare-and-double-strings-1/
/*
Xsquare got bored playing with the arrays all the time. Therefore, he has decided to play with the strings. Xsquare called a string P a "double string" if string P is not empty and can be broken into two strings A and B such that A + B = P and A = B. for eg : strings like "baba" , "blabla" , "lolo" are all double strings whereas strings like "hacker" , "abc" , "earth" are not double strings at all.

Today, Xsquare has a special string S consisting of lower case English letters. He can remove as many characters ( possibly zero ) as he wants from his special string S. Xsquare wants to know , if its possible to convert his string S to a double string or not.

Help him in accomplishing this task.

Note :

Order of the characters left in the string is preserved even after deletion of some characters.

Input :
First line of input contains a single integer T denoting the number of test cases. First and the only line of each test case contains a string S denoting Xsquare's special string.

Output :
For each test case, print "Yes" if it is possible to convert the given string to a double string. Print "No" otherwise.

Constraints :
1 ≤ T ≤ 100
1 ≤ |S| ≤ 100
String |S| consists of lower case english alphabets only. 
*/


namespace XSquare_and_Double_Strings
{
    public static class AppHelper
    {
        public static void DoubleStrings(String str)
        {
            if (str.GroupBy(g => g).Select(g => new { Key = g.Key, Count = g.Count() }).Any(g => g.Count > 1))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 NoOfTestCases = Convert.ToInt32(Console.ReadLine());
            while (NoOfTestCases != 0)
            {
                String str = Console.ReadLine();
                AppHelper.DoubleStrings(str);
                NoOfTestCases = NoOfTestCases - 1;

            }
        }
    }
}
