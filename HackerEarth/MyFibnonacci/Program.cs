﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerearth.com/problem/algorithm/myfibonacci-easy-contest/description/

/*Many of you know the famous Fibonacci sequence F:

F[1] = 1
F[2] = 1
F[i] = F[i - 1] + F[i - 2] for i > 2
Thus each number in sequence is a sum of two previous numbers except two first which are define as 1.

You've decided to create you own Fibonacci sequence. It's very similar to the one described above, but the first two numbers now are arbitrary non-negative integers A and B ( F[1] = A and F[2] = B ). Now you want to compute the N-th number in your sequence.

Input
The only line contains 3 space-separated integers A, B, N.

Output
Output one integer - the N-th number in your sequence.

Constraints

0 < A, B, N <= 10
SAMPLE INPUT 
1 3 4
SAMPLE OUTPUT 
7*/

namespace MyFibnonacci
{
    public static class AppHelper
    {
        public static void NthTerm(Int32[] arr)
        {
            Int32 Tone = arr[0];
            Int32 Ttwo = arr[1];
            Int32 n = arr[2];
            Int32 sum = 0;
            if (n.Equals(2))
            {
                Console.WriteLine(Ttwo);
            }
            else if (n.Equals(1))
            {
                Console.WriteLine(Tone);
            }
            else
            {
                for (Int32 i = 3; i <= n; i++)
                {
                    sum = Tone + Ttwo;
                    Tone = Ttwo;
                    Ttwo = sum;
                }
                Console.WriteLine(sum);
            }

        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Int32[] arr = Console.ReadLine()
                    .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(a => Convert.ToInt32(a))
                    .ToArray<Int32>();
            AppHelper.NthTerm(arr);
        }
    }
}
