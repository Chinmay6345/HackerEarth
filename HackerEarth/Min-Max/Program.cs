using System;
using System.Linq;

//https://www.hackerearth.com/practice/basic-programming/implementation/basics-of-implementation/practice-problems/algorithm/min-max-3/submissions/
namespace Min_Max
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Int32.Parse(Console.ReadLine());
            Int32[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                           .Select(a => Int32.Parse(a)).ToArray<Int32>();
            Int32 min = array.Min();
            Int32 max = array.Max();
            Boolean isPresent = true;
            for (Int32 i = min + 1; i < max; i++)
            {
                if (!array.Contains(i))
                {
                    isPresent = false;
                    break;
                }
            }
            Console.WriteLine(isPresent ? "YES" : "NO");
        }
    }
}
