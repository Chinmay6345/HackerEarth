using System;
using System.Collections.Generic;
using System.Linq;

//https://www.hackerearth.com/practice/basic-programming/implementation/basics-of-implementation/practice-problems/algorithm/complete-string-4/
/*
A string is said to be complete if it contains all the characters from a to z. Given a string, check if it complete or not.

Input
First line of the input contains the number of strings N. It is followed by N lines each contains a single string.

Output
For each test case print "YES" if the string is complete, else print "NO"

Constraints
1 <= N <= 10
The length of the string is at max 100 and the string contains only the characters a to z

SAMPLE INPUT 
3
wyyga
qwertyuioplkjhgfdsazxcvbnm
ejuxggfsts
SAMPLE OUTPUT 
NO
YES
NO 
*/
namespace Complete_String
{
    public class Constants
    {
        public const String YES = "YES";
        public const String NO = "NO";        
    }
    public static class AppHelper
    {
        public static void Complete(String lString)
        {
            Char [] stringarray = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            List<Char> lstchar = new List<char>(stringarray);
            foreach(Char ipstring in lString)
            {
                if(lstchar.Contains(ipstring))
                {
                    lstchar.Remove(ipstring);
                }
            }
            if(lstchar.Count==0)
            {
                Console.WriteLine(Constants.YES);
            }
            else
            {
                Console.WriteLine(Constants.NO);
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Int32 NoOfTestCases = Convert.ToInt32(Console.ReadLine());
            while(NoOfTestCases !=0)
            {
                String input=Console.ReadLine().ToLower();
                AppHelper.Complete(input);
                NoOfTestCases = NoOfTestCases - 1;
            }
           
        }
    }
}
