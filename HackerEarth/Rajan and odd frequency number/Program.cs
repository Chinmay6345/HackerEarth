using System;
using System.Linq;

//https://www.hackerearth.com/practice/basic-programming/bit-manipulation/basics-of-bit-manipulation/practice-problems/algorithm/danny-and-his-loneliness/
/*
Given an array of numbers of size (2*n+1).Raja is unable to find the number which is present odd number of times.It is guaranteed that only one such number exists.Can you help Raja in finding the number which is present odd number of times?

Input
First line contains value of n.
Second line contains (2*n+1) array elements.
Output
Print the required number.
Constraints
1≤ n ≤ 
1≤ a[i] ≤ 

SAMPLE INPUT 
2
1 2 3 2 1
SAMPLE OUTPUT 
3 
*/
namespace Rajan_and_odd_frequency_number
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Convert.ToInt32(Console.ReadLine());
            Int32[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => Convert.ToInt32(a)).ToArray<Int32>();
            Int32 result = array.GroupBy(a => a).Where(a => a.Count() == 1).Select(a => Convert.ToInt32(a.Key.ToString())).First();
            Console.WriteLine(result);
        }
    }
}
