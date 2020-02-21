using System;
using System.Collections.Generic;
using System.Linq;
//https://www.hackerearth.com/practice/algorithms/searching/linear-search/practice-problems/algorithm/easy-sum-set-problem-7e6841ca/

namespace Easy_Sum_Set_Problem
{
    public static class AppHelper
    {
        public static List<Int32> Method(Int32[] a, Int32[] c)
        {
            bool CanAdd = false;
            List<Int32> bdash = new List<Int32>();
            for (Int32 j = 0; j < c.Length; j++)
            {
                Int32 difference = c[j] - a[0];
                if (difference + a[0] == c[j])
                {
                    for (Int32 t = 0; t < a.Length; t++)
                    {
                        Int32 addition = difference + a[t];
                        if (c.Contains(addition))
                        {
                            CanAdd = true;
                        }
                        else
                        {
                            CanAdd = false;
                            break;
                        }
                    }
                    if (CanAdd)
                    {
                        bdash.Add(difference);
                    }
                }
            }
            bdash = bdash.Distinct().OrderBy(element => element).ToList();
            return bdash;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32 NoOfElementsOfA = Convert.ToInt32(Console.ReadLine());
            Int32[] a = Console.ReadLine().Split(' ').Select(elementsOfA => Convert.ToInt32(elementsOfA)).ToArray();
            Int32 NoOfElementsOfC = Convert.ToInt32(Console.ReadLine());
            Int32[] c = Console.ReadLine().Split(' ').Select(elementsOfC => Convert.ToInt32(elementsOfC)).ToArray();
            List<Int32> b = AppHelper.Method(a, c);
            b.ForEach(delegate (int element)
            {
                Console.Write(element + " ");
            });
        }
    }
}
