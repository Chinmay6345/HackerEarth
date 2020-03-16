using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerearth.com/problem/algorithm/count-carry-problem-4/description/
/*
Regional Students's are taught to add multi-digit numbers from right-to-left one digit at a time. Many find the "carry" operation - in which 1 is carried from one digit position to be added to the next - to be a significant challenge. Your job is to count the number of carry operations for each of addition problem so that educators may assess their difficulty.

For the input first line contains n number of records which is less then 1000. And then each line contains two numbers with spacing between them as shown in sample.

SAMPLE INPUT 
3
123 456
555 555
123 594 
*/
namespace Count_carryproblem
{
    public static class AppHelper
    {
        public static void CarryCount(String[] arr)
        {
            String a = arr[0];
            String b = arr[1];
            if (a.Length > b.Length)
            {
                while (true)
                {
                    if (b.Length < a.Length)
                        b = "0" + b;
                    else
                        break;
                }
            }
            else if (a.Length < b.Length)
            {
                while (true)
                {
                    if (a.Length < b.Length)
                        a = "0" + a;
                    else
                        break;
                }
            }
            Int32 carry = 0;
            Int32 count = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Int32 x = Int32.Parse(Convert.ToString(a[i]));
                Int32 y = Int32.Parse(Convert.ToString(b[i]));
                Int32 sum = x + y + carry;
                if (sum >= 10)
                {
                    count++;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
            }
            if (count == 0)
                Console.WriteLine("No carry operation");
            else if (count == 1)
                Console.WriteLine(count + " " + "carry operation");
            else
                Console.WriteLine(count + " " + "carry operations");
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Int32.Parse(Console.ReadLine());
            while (n != 0)
            {
                String[] arr = Console.ReadLine()
                          .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                          .ToArray<String>();
                AppHelper.CarryCount(arr);
                n = n - 1;
            }
        }
    }
}
