using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeated_K_times
{
    //https://www.hackerearth.com/practice/algorithms/searching/linear-search/practice-problems/algorithm/repeated-k-times/
    class Program
    {
        public static void Main(string[] args)
        {
            Int32 arraySize = Int32.Parse(Console.ReadLine());
            Int32[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(element => Convert.ToInt32(element)).ToArray<Int32>();
            Int32 k = Int32.Parse(Console.ReadLine());
            Console.WriteLine(array.GroupBy(a => a).Where(a => a.Count() == k).Select(a => Convert.ToInt32(a.Key.ToString())).Min());
        }
    }
}
