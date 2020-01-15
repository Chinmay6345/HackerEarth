using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Search
{
    //https://www.hackerearth.com/practice/algorithms/searching/linear-search/practice-problems/algorithm/simple-search-4/
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32 ArraySize = Convert.ToInt32(Console.ReadLine());
            Int32[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(element => Convert.ToInt32(element)).ToArray<Int32>();
            Int32 elementToSearch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Array.IndexOf(array, elementToSearch));
        }
    }
}
