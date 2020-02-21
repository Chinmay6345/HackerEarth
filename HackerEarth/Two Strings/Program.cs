using System;
using System.Collections.Generic;
using System.Linq;

//https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/two-strings-4/

namespace Two_Strings
{
    public static class Util
    {
        public static String EqualStrings(String Input)
        {
            String[] array = Input.Split(' ');
            var first = array[0].OrderBy(a => a);
            var second = array[1].OrderBy(a => a);
            if (first.SequenceEqual(second))
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
        public class Program
        {
            public static void Main(String[] args)
            {
                List<String> lst = new List<String>();
                Int32 n = Int32.Parse(Console.ReadLine());
                for (Int32 i = 0; i < n; i++)
                {
                    String input = Console.ReadLine();
                    lst.Add(Util.EqualStrings(input));
                }
                lst.ForEach(delegate (String s) { Console.WriteLine(s); });
            }
        }
    }
}
