using System;
using System.Linq;

//https://www.hackerearth.com/practice/data-structures/arrays/1-d/practice-problems/algorithm/monk-and-lucky-minimum-3/

namespace Monk_and_Lucky_Minimum
{
    public static class AppHelper
    {
        public static void LuckyMinimum(Int32[] arr)
        {
            Int32 min = arr.Min();
            String outputstr = arr.Count(s => s == min) % 2 == 0 ? "Unlucky" : "Lucky";
            Console.WriteLine(outputstr);
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 no_testcases = Convert.ToInt32(Console.ReadLine());
            while (no_testcases != 0)
            {
                Int32 arraylength = Convert.ToInt32(Console.ReadLine());
                Int32[] arr = Console.ReadLine()
                            .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(a => Int32.Parse(a)).ToArray();
                AppHelper.LuckyMinimum(arr);
                no_testcases--;
            }
        }
    }
}
