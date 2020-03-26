using System;

//https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/life-the-universe-and-everything/
/*
Your program is to use the brute-force approach in order to find the Answer to Life, the Universe, and Everything. More precisely... rewrite small numbers from input to output. Stop processing input after reading in the number 42. All numbers at input are integers of one or two digits. 
*/
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
