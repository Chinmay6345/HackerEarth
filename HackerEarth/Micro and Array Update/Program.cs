using System;
using System.Collections.Generic;
using System.Linq;

//https://www.hackerearth.com/practice/data-structures/arrays/1-d/practice-problems/algorithm/micro-and-array-update/
namespace Micro_and_Array_Update
{
    public static class AppHelper
    {
        public static Int32 GetCount(Int32[] array, Int32 target)
        {
            if(array.All(a=>a >=target))
            {
                return 0;
            }
            int k= target- array.Min();
            return k;
        }
    }
 
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Int32> lstIntg = new List<Int32>();
            Int32 n = Int32.Parse(Console.ReadLine());
            while (n != 0)
            {
                for (Int32 i = 0; i < n; i++)
                {
                    Int32[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => Int32.Parse(a)).ToArray<Int32>();
                    Int32[] array1 = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => Int32.Parse(a)).ToArray<Int32>();
                    lstIntg.Add(AppHelper.GetCount(array1,array[1]));
                    n--;
                }
            }
            lstIntg.ForEach(k=>{ Console.WriteLine(k); });
            Console.ReadLine();
        }
    }
}
