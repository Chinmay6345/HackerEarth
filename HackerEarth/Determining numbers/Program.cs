using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerearth.com/practice/basic-programming/bit-manipulation/basics-of-bit-manipulation/practice-problems/algorithm/find-the-numbers-75f24949/

namespace Determining_numbers
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Convert.ToInt32(Console.ReadLine());
            Int32[] array = Console.ReadLine()
                           .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(a => Convert.ToInt32(a))
                           .ToArray<Int32>();
            Console.WriteLine(String.Join(" ", array.GroupBy(a => a)
                                                    .Where(a => a.Count() == 1)
                                                    .Select(a => Int32.Parse(Convert.ToString(a.Key))).OrderBy(a => a)));
        }
    }
}
