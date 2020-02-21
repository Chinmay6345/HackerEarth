using System;
using System.Collections.Generic;

//https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/anagrams-651/

namespace Anagrams
{
    public static class AppHelper
    {
        public static Int32 CountToMakeAnagram(String A, String B)
        {
            Int32[] array1 = new Int32[26];
            Int32[] array2 = new Int32[26];
            Int32 i, result = 0;
            for (i = 0; i < 26; i++)
            {
                array1[i] = array2[i] = 0;
            }
            for (i = 0; i < A.Length; i++)
            {
                array1[(Int32)(A[i] - 'a')]++;
            }
            for (i = 0; i < B.Length; i++)
            {
                array2[(Int32)(B[i] - 'a')]++;
            }
            for (i = 0; i < 26; i++)
            {
                result = (result + array1[i] + array2[i]) - 2 * Math.Min(array1[i], array2[i]);
            }
            return result;
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Int32.Parse(Console.ReadLine());
            List<Int32> lst = new List<Int32>();
            while (n != 0)
            {
                String A = Console.ReadLine();
                String B = Console.ReadLine();
                lst.Add(AppHelper.CountToMakeAnagram(A, B));
                n = n - 1;
            }
            lst.ForEach(delegate (Int32 k)
            {
                Console.WriteLine(k);
            });
        }
    }
}
