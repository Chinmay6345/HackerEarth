using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
In the previous problem Chandu bought some unsorted arrays and sorted them (in non-increasing order). Now, he has many sorted arrays to give to his girlfriend. But, the number of sorted arrays are very large so Chandu decided to merge two sorted arrays into one sorted array. But he is too lazy to do that. So, he asked your help to merge the two sorted arrays into one sorted array (in non-increasing order).

Input:
First line contains an integer T, denoting the number of test cases.
First line of each test case contains two space separated integers N and M, denoting the size of the two sorted arrays.
Second line of each test case contains N space separated integers, denoting the first sorted array A.
Third line of each test case contains M space separated integers, denoting the second array B.

Output:
For each test case, print (N + M) space separated integer representing the merged array.

Constraints:
1 <= T <= 100
1 <= N, M <= 5*104
0 <= Ai, Bi <= 109

SAMPLE INPUT 
1
4 5
9 7 5 3
8 6 4 2 0
SAMPLE OUTPUT 
9 8 7 6 5 4 3 2 0
 
*/
//https://www.hackerearth.com/practice/algorithms/sorting/merge-sort/practice-problems/algorithm/chandu-and-his-girlfriend-returns/
namespace Chandu_and_his_Girlfriend_Returns
{
    public static class AppHelper
    {
        public static void Merge(Int64[] A, Int64[] B)
        {
            Int64[] C = A.Concat(B).OrderByDescending(g => g).ToArray<Int64>();
            Console.WriteLine(String.Join(" ", C.Select(g => g)));
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Int32.Parse(Console.ReadLine());
            while (n != 0)
            {
                Int64[] arr = Console.ReadLine()
                              .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(a => Int64.Parse(a))
                            .ToArray<Int64>();
                Int64[] A = Console.ReadLine()
                              .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(a => Int64.Parse(a))
                            .ToArray<Int64>();
                Int64[] B = Console.ReadLine()
                              .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(a => Int64.Parse(a))
                            .ToArray<Int64>();
                AppHelper.Merge(A, B);
                n = n - 1;
            }
        }
    }
}
