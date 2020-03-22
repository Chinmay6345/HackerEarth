using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerearth.com/practice/basic-programming/bit-manipulation/basics-of-bit-manipulation/practice-problems/algorithm/find-the-numbers-75f24949/
/*
You are given an array of integers. The special property of the array is that exactly two different elements occur once while other elements occur twice.

You are required to determine those two elements.

Input format

First line: Integer  denoting the number of elements in the array
Second line:  space-separated integers denoting the values in the array
Output format

Print two space-separated integers that occur once in the array in ascending order.

Constraints


, where  denotes the  element in the array

SAMPLE INPUT 
8
1 2 3 4 5 5 3 4
SAMPLE OUTPUT 
1 2 
     
*/
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
