using System;

//https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/life-the-universe-and-everything/

namespace Life__the_Universe__and_Everything
{
    public class Program
    {
        public static void Main(String[] args)
        {
            while (true)
            {
                Int32 k = Convert.ToInt32(Console.ReadLine());
                if (k.Equals(42))
                {
                    return;
                }
                Console.WriteLine(k);
            }
        }
    }
}
