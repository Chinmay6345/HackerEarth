using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerearth.com/problem/algorithm/fun-with-strings/description/

namespace Fun_with_Strings
{
    public class Program
    {
        public static long getcount(long n)
        {
            long[] array = new long[n + 1];
            array[1] = 2;
            array[2] = 3;
            for (int i = 3; i <= n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            return array[n];
        }

        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(getcount(n));

        }
    }
}
