using System;
using System.Linq;

namespace zooos
{
    public static class AppHelper
    {
        public static String IsIndentical(String input)
        {
            return ((input.Where(a => a == 'z').Count() * 2) == (input.Length - input.Where(a => a == 'z').Count() )) ? "YES" : "NO";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            String input = Console.ReadLine();
            Console.WriteLine(AppHelper.IsIndentical(input));
            Console.ReadLine();
        }
    }
}
