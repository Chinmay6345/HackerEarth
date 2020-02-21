using System;

//https://www.hackerearth.com/practice/algorithms/string-algorithm/basics-of-string-manipulation/practice-problems/algorithm/terrible-chandu/description/

namespace Terrible_Chandu
{
    public static class AppHelper
    {
        public static void ReverseString(String str)
        {
            Char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(new String(arr));
        }
    }


    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 NoOfTestCases = Int32.Parse(Console.ReadLine());
            while (NoOfTestCases != 0)
            {
                String input = Console.ReadLine();
                AppHelper.ReverseString(input);
                NoOfTestCases = NoOfTestCases - 1;
            }
        }
    }
}
