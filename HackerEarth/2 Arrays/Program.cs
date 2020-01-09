using System;
using System.Linq;

//https://www.hackerearth.com/practice/data-structures/arrays/1-d/practice-problems/algorithm/2-arrays-90c9019c/

namespace _2_Arrays
{
   public static class AppHelper
    {
        public static void NoOfWays(Int32 [] a, Int32 [] b)
        {
            Int32 returnvalue=0;
            Int32 NoOfNegativeElementsInArrayA= a.Where(k=>k==-1).Count();
            Int32 NoOfNegativeElementsInArrayB= b.Where(k=>k==-1).Count();
            if(a.All(element=>element== a.First()) || b.All(element=>element== b.First()))
            {
                Console.WriteLine(returnvalue);
            }
            else if(NoOfNegativeElementsInArrayA > 0 && NoOfNegativeElementsInArrayB==0)
            {
                Int32 [] newArrayForA= a.Except(new Int32 [] { -1 } ).ToArray();
                Int32 SumofArrayAExceptMinusOne= a.Except(new Int32 [] { -1 }).ToArray().Sum();
                Int32 SumOfB= b.Sum();
                Int32 difference=SumOfB-SumofArrayAExceptMinusOne;
                bool AreAllElementsGreater=b.Zip(newArrayForA, (i1, i2) => i2 > i1).All(secondGreater => secondGreater);
                if(AreAllElementsGreater)
                {
                    Console.WriteLine(returnvalue);
                }
                else if(NoOfNegativeElementsInArrayA==1)
                {                 
                    for(Int32 i=1; i<=difference;i++)
                    {
                        if(i + SumofArrayAExceptMinusOne ==SumOfB)
                        {
                            returnvalue++;
                        }
                    }
                    Console.WriteLine(returnvalue);
                }
                else
                {
                   returnvalue =  difference > 0 ? difference+1 : 0;
                    Console.WriteLine(returnvalue);
                }               
            }
            else if(NoOfNegativeElementsInArrayA == 0 && NoOfNegativeElementsInArrayB > 0)
            {
                Int32 [] newArrayForB= b.Except(new Int32 [] { -1 } ).ToArray();
                Int32 SumofArrayBExceptMinusOne= b.Except(new Int32 [] { -1 }).ToArray().Sum();
                Int32 SumOfA= a.Sum();
                Int32 difference=SumOfA-SumofArrayBExceptMinusOne;
                bool AreAllElementsGreater=b.Zip(newArrayForB, (i1, i2) => i2 > i1).All(secondGreater => secondGreater);
                if(AreAllElementsGreater)
                {
                    Console.WriteLine(returnvalue);
                }
                else if(NoOfNegativeElementsInArrayB==1)
                {                
                    for(Int32 i=1; i<=difference;i++)
                    {
                        if(i + SumofArrayBExceptMinusOne ==SumOfA)
                        {
                            returnvalue++;
                        }
                    }
                    Console.WriteLine(returnvalue);
                }
                else 
                {
                    returnvalue =  difference > 0 ? difference+1 : 0;
                    Console.WriteLine(returnvalue);
                }
            }
            else if(NoOfNegativeElementsInArrayA > 0 && NoOfNegativeElementsInArrayB > 0)
            {
                 Int32 SumofArrayAExceptMinusOne= a.Except(new Int32 [] { -1 }).ToArray().Sum();
                 Int32 SumofArrayBExceptMinusOne= b.Except(new Int32 [] { -1 }).ToArray().Sum();
                 Int32 difference = SumofArrayAExceptMinusOne > SumofArrayBExceptMinusOne ? SumofArrayAExceptMinusOne-SumofArrayBExceptMinusOne : SumofArrayBExceptMinusOne-SumofArrayAExceptMinusOne;
                if(difference > 1000)
                {
                    Console.WriteLine("Infinite");
                }
            }
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32 length = Int32.Parse(Console.ReadLine());
            Int32[] a = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(p => Convert.ToInt32(p)).ToArray<Int32>();
            Int32[] b = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(q => Convert.ToInt32(q)).ToArray<Int32>();
            AppHelper.NoOfWays(a,b);
        }
    }
}
