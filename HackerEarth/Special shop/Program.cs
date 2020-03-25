using System;
using System.Linq;
//https://www.hackerearth.com/practice/algorithms/searching/linear-search/practice-problems/algorithm/special-shop-69904c91/
/*
Creatnx now wants to decorate his house by flower pots. He plans to buy exactly  ones. He can only buy them from Triracle's shop. There are only two kind of flower pots available in that shop. The shop is very strange. If you buy  flower pots of kind 1 then you must pay  and  if you buy  flower pots of kind 2. Please help Creatnx buys exactly  flower pots that minimizes money he pays.

Input Format

The first line contains a integer  denoting the number of test cases.

Each of test case is described in a single line containing three space-separated integers .

Output Format

For each test case, print a single line containing the answer.

Constraints

 

SAMPLE INPUT 
2
5 1 2
10 2 4

SAMPLE OUTPUT 
17
134
Explanation
Query 1: we have to buy exactly  pots. There are six possible options:

Buy  pot of first kind,  pots of second kind. The cost is: .
Buy  pot of first kind,  pots of second kind. The cost is: .
Buy  pots of first kind,  pots of second kind. The cost is: .
Buy  pots of first kind,  pots of second kind. The cost is: .
Buy  pots of first kind,  pot of second kind. The cost is: .
Buy  pots of first kind,  pot of second kind. The cost is: .
So, the optimal cost is .
*/
namespace Special_shop
{
    public static class AppHelper
    {
        public static Int64 OptimalAmount(Int64[] array)
        {
            Int64 n = array[0];
            Int64 a = array[1];
            Int64 b = array[2];
            double x = Math.Round(((double)b * n) / ((double)a + (double)b));
            double y = (double)n - x;
            return Convert.ToInt64(a * x * x + b * y * y); ;
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Int64 n = Convert.ToInt64(Console.ReadLine());
            while (n != 0)
            {
                Int64[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                  .Select(a => Convert.ToInt64(a))
                                                  .ToArray();
                Console.WriteLine(AppHelper.OptimalAmount(array));
                n = n - 1;
            }
        }
    }
}
