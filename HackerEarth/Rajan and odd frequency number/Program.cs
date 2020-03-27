using System;
using System.Collections.Generic;
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
            Int32[] array = { 1,2, 3, 2, 1 };
            Dictionary<Int32, Int32> dict = new Dictionary<Int32, Int32>();
            for(Int32 i=0;i<array.Length;i++)
            {
                if(dict.ContainsKey(array[i]))
                {
                    dict[array[i]]++;
                }
                else
                {
                    dict[array[i]] = 1;
                }
            }
            Console.WriteLine(dict.Where(a => a.Value == 1).Select(a => a.Key).First()) ;
        }
    }
}
