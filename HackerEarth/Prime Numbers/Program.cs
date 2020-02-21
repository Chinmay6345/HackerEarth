using System;


//https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/prime-number-8/
namespace Prime_Numbers
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Int32.Parse(Console.ReadLine());
            Int32 i = 0;
            Int32 j = 0;
            int flag = 0;
            for (i = 2; i <= n; i++)
            {
                j = 2;
                flag = 0;
                while (j <= (i / 2))
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                    j++;
                }
                if (flag == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
