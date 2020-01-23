using System;
using System.Linq;
//https://www.hackerearth.com/practice/algorithms/searching/linear-search/practice-problems/algorithm/special-shop-69904c91/

namespace Special_shop
{
    public static class AppHelper
    {
        public static Int64 OptimalAmount(Int64[] array)
        {
            Int64 n = array[0];
            Int64 a = array[1];
            Int64 b = array[2];
            double x = Math.Round(((double)b * n) / ((double)a + (double)b));
            double y = (double)n - x;
            return Convert.ToInt64(a * x * x + b * y * y); ;
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Int64 n = Convert.ToInt64(Console.ReadLine());
            while (n != 0)
            {
                Int64[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                  .Select(a => Convert.ToInt64(a))
                                                  .ToArray();
                Console.WriteLine(AppHelper.OptimalAmount(array));
                n = n - 1;
            }
        }
    }
}
