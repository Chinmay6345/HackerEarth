using System;
using System.Collections.Generic;

//https://www.hackerearth.com/problem/golf/xenny-and-uniqueness/

namespace Xenny_and_Uniqueness
{
    public static class AppHelper
    {
        public static void UniqueStrings(List<String> lst)
        {
            HashSet<String> HSet = new HashSet<String>(lst);
            Console.WriteLine(HSet.Count);
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Convert.ToInt32(Console.ReadLine());
            List<String> lstString = new List<String>();
            HashSet<String> HSet = new HashSet<String>();
            while (n != 0)
            {
                String str = Console.ReadLine();
                HSet.Add(str);
                n = n - 1;
            }
            Console.WriteLine(HSet.Count);
        }
    }
}
