using System;
using System.Collections.Generic;
using System.Linq;

namespace MinMax
{
    //https://www.hackerearth.com/practice/algorithms/searching/linear-search/practice-problems/algorithm/min-max-8/
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32 n = Int32.Parse(Console.ReadLine());
            List<int> lst=Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => int.Parse(a)).ToList();
            int minsum = lst.Sum() - lst.Max();
            int maxsum = lst.Sum() - lst.Min();
            Console.WriteLine(minsum + " " + maxsum);
            Console.ReadLine();
        }

    }
}
