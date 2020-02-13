using System;
using System.Linq;
//https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/find-product/
namespace Final_Product
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 p = (Int32)Math.Pow(10, 9) + 7;
            Int32 n = Int32.Parse(Console.ReadLine());
            Int64 result = 1;
            Int64[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => Convert.ToInt64(a)).ToArray<Int64>();
            for (Int32 i = 0; i < array.Length; i++)
            {
                result = (result * array[i]) % p;
            }
            Console.WriteLine(result);

        }
    }
}
